#include<iostream>
#include<sstream>
#include<stdio.h>
#include<math.h>
#include<vector>
#include <opencv2/opencv.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/core/core.hpp>
#include <opencv2/nonfree/nonfree.hpp>

using namespace cv; 
using namespace std;

Point2f GiaoGiem(float r1,float t1, float r2, float t2)
{
	Point2f Goc;
	float a1,b1,c1,a2,b2,c2;
	a1 = -cos(t1)/sin(t1);
	a2 = -cos(t2)/sin(t2);
	b1 = r1/sin(t1);
	b2 = r2/sin(t2);
	Goc.x = (b2-b1)/(a1-a2);
	Goc.y = Goc.x*a1+b1;
	return Goc;
}
int main(int argc, char*argv[])
{
	VideoCapture cap(1); 
	//VideoCapture cap("MyVideo.avi"); 
	if ( !cap.isOpened() )
	{
		cout << "Cannot open the video file" << endl;
		return -1;
	}
	Point PP4,PP1,PP2,PP3;
	while(1)
	{
		Mat OriginalImg;
		bool bSuccess = cap.read(OriginalImg);
		if (!bSuccess)
		{
			break;
		}

		Mat CopyOriginalImg = OriginalImg.clone();

		Mat GrayImg;
		cvtColor(CopyOriginalImg,GrayImg,CV_RGB2GRAY);
		equalizeHist(GrayImg,GrayImg);
		//imshow("GrayImg",GrayImg);

		Mat ThersholdImg;
		adaptiveThreshold(GrayImg,ThersholdImg,255,CV_ADAPTIVE_THRESH_GAUSSIAN_C,
										CV_THRESH_BINARY_INV,31,11);
		erode(ThersholdImg,ThersholdImg,
			getStructuringElement(CV_SHAPE_RECT, Size(5,5)));
		dilate(ThersholdImg,ThersholdImg,
			getStructuringElement(CV_SHAPE_RECT, Size(5,5)));

		//imshow("ThersholdImg",ThersholdImg);
		vector<Vec2f> lines;
		HoughLines(ThersholdImg, lines, 1, CV_PI/180, 200, 0, 0 );
		vector<Vec2f> linesTypeI,linesTypeII,linesTypeIII,linesTypeIV;
		int linesISize=0,linesIISize=0,linesIIISize=0,linesIVSize=0;
		for( size_t i = 0; i <(int)lines.size(); i++ )
		{
			if((lines[i][1]<3.14/(float)4)|(lines[i][1]>3*3.14/(float)4))
			{

				if(abs(lines[i][0])<320)//Loai1
				{
				
					linesTypeI.push_back(0);
					linesTypeI[linesISize][0]=lines[i][0];
					linesTypeI[linesISize][1]=lines[i][1];
					linesISize++;
				}
				else//Loai3
				{
				
					linesTypeIII.push_back(0);
					linesTypeIII[linesIIISize][0]=lines[i][0];
					linesTypeIII[linesIIISize][1]=lines[i][1];
					linesIIISize++;
				}
			}
			else
			{
				if(abs(lines[i][0])<240)//Loai2
				{
				
					linesTypeII.push_back(0);
					linesTypeII[linesIISize][0]=lines[i][0];
					linesTypeII[linesIISize][1]=lines[i][1];
					linesIISize++;
				}
				else//Loai4
				{
					linesTypeIV.push_back(0);
					linesTypeIV[linesIVSize][0]=lines[i][0];
					linesTypeIV[linesIVSize][1]=lines[i][1];
					linesIVSize++;
				}
			}
		}

		

		if((linesTypeI.size()>0)&&(linesTypeII.size()>0)&&(linesTypeIII.size()>0)&&(linesTypeIV.size()>0))
		{
			//Loai 1 
			double rI=0, ttI=0;
			for( size_t i = 0; i <(int)linesTypeI.size(); i++ )
			{
				rI += abs(linesTypeI[i][0]);
				if(linesTypeI[i][1] < 3.14/4) ttI += linesTypeI[i][1];
				else ttI -= 3.14-linesTypeI[i][1];
			}
				rI=rI/(double)linesTypeI.size();
				ttI=ttI/(double)linesTypeI.size();
			//Loai 2 
			double rII=0, ttII=0;
			for( size_t i = 0; i <(int)linesTypeII.size(); i++ )
			{
					rII += abs(linesTypeII[i][0]);
					ttII += linesTypeII[i][1];
			}
				rII=rII/(double)linesTypeII.size();
				ttII=ttII/(double)linesTypeII.size();
			//Loai 3
			double rIII=0, ttIII=0;
			for( size_t i = 0; i <(int)linesTypeIII.size(); i++ )
			{
					rIII += abs(linesTypeIII[i][0]);
					if(abs(linesTypeIII[i][1]) < 3.14/4) ttIII += abs(linesTypeIII[i][1]);
					else ttIII -= 3.14-abs(linesTypeIII[i][1]);
			}
				rIII=rIII/(double)linesTypeIII.size();
				ttIII=ttIII/(double)linesTypeIII.size();
			//Loai 4
			double rIV=0, ttIV=0;
			for( size_t i = 0; i <(int)linesTypeIV.size(); i++ )
			{
					rIV += abs(linesTypeIV[i][0]);
					ttIV += abs(linesTypeIV[i][1]);
			}
				rIV=rIV/(double)linesTypeIV.size();
				ttIV=ttIV/(double)linesTypeIV.size();

			//for( size_t i = 0; i <(int)lines.size(); i++ )
			//{
			//			float rho = lines[i][0], theta = lines[i][1];
			//			Point pt1, pt2;
			//			double a = cos(theta), b = sin(theta);
			//			double x0 = a*rho, y0 = b*rho;
			//			pt1.x = cvRound(x0 + 1000*(-b));
			//			pt1.y = cvRound(y0 + 1000*(a));
			//			pt2.x = cvRound(x0 - 1000*(-b));
			//			pt2.y = cvRound(y0 - 1000*(a));
			//			//line(OriginalImg, pt1, pt2, Scalar(255,0,0), 1, CV_AA);
			//}

			Point pt1, pt2;
			double a, b;
			double x0, y0;
			a = cos(ttI), b = sin(ttI);
			x0 = a*rI, y0 = b*rI;
			pt1.x = cvRound(x0 + 1000*(-b));
			pt1.y = cvRound(y0 + 1000*(a));
			pt2.x = cvRound(x0 - 1000*(-b));
			pt2.y = cvRound(y0 - 1000*(a));
			line(OriginalImg, pt1, pt2, Scalar(0,255,0), 3, CV_AA);
			a = cos(ttII), b = sin(ttII);
			x0 = a*rII, y0 = b*rII;
			pt1.x = cvRound(x0 + 1000*(-b));
			pt1.y = cvRound(y0 + 1000*(a));
			pt2.x = cvRound(x0 - 1000*(-b));
			pt2.y = cvRound(y0 - 1000*(a));
			line(OriginalImg, pt1, pt2, Scalar(0,255,0), 3, CV_AA);
			a = cos(ttIII), b = sin(ttIII);
			x0 = a*rIII, y0 = b*rIII;
			pt1.x = cvRound(x0 + 1000*(-b));
			pt1.y = cvRound(y0 + 1000*(a));
			pt2.x = cvRound(x0 - 1000*(-b));
			pt2.y = cvRound(y0 - 1000*(a));
			line(OriginalImg, pt1, pt2, Scalar(0,255,0), 3, CV_AA);
			a = cos(ttIV), b = sin(ttIV);
			x0 = a*rIV, y0 = b*rIV;
			pt1.x = cvRound(x0 + 1000*(-b));
			pt1.y = cvRound(y0 + 1000*(a));
			pt2.x = cvRound(x0 - 1000*(-b));
			pt2.y = cvRound(y0 - 1000*(a));
			line(OriginalImg, pt1, pt2, Scalar(0,255,0), 3, CV_AA);

			PP4 = GiaoGiem(rI,ttI,rIV,ttIV);
			PP1 = GiaoGiem(rI,ttI,rII,ttII);
			PP2 = GiaoGiem(rII,ttII,rIII,ttIII);
			PP3 = GiaoGiem(rIII,ttIII,rIV,ttIV);

			
		}
		

		/////////////////////////////////////////////////////////////////
		circle(OriginalImg,PP1,5,Scalar(0,0,255),4,8,0);
			circle(OriginalImg,PP2,5,Scalar(0,0,255),4,8,0);
			circle(OriginalImg,PP3,5,Scalar(0,0,255),4,8,0);
			circle(OriginalImg,PP4,5,Scalar(0,0,255),4,8,0);

			Point2f inputQuad[4]; 
			inputQuad[0] = Point2f( PP1.x, PP1.y);
			inputQuad[1] = Point2f( PP2.x, PP2.y);
			inputQuad[3] = Point2f( PP3.x, PP3.y);
			inputQuad[2] = Point2f( PP4.x, PP4.y); 

			Point2f outputQuad[4];
			outputQuad[0] = Point2f( 0   ,0  );
			outputQuad[1] = Point2f( 825 ,0  );
			outputQuad[2] = Point2f( 0   ,480);
			outputQuad[3] = Point2f( 825 ,480);

			Mat lambda = getPerspectiveTransform( inputQuad, outputQuad );
			Mat chessboard=Mat::zeros( 480,825, OriginalImg.type() );
			warpPerspective(CopyOriginalImg,chessboard,lambda,chessboard.size() );
			Mat Copychessboard = chessboard.clone();
			//imshow("chessboard",Copychessboard);

			// >>>>> Noise smoothing
			cv::Mat blur;
			cv::GaussianBlur(chessboard, blur, cv::Size(5, 5), 3.0, 3.0);
			// <<<<< Noise smoothing
			//imshow("chessboard1",blur);

			// >>>>> HSV conversion
			cv::Mat frmHsv;
			cv::cvtColor(blur, frmHsv, CV_BGR2HSV);
			// <<<<< HSV conversion
			//imshow("chessboard2",frmHsv);

			// >>>>> Color Thresholding
			cv::Mat rangeRes = cv::Mat::zeros(chessboard.size(), CV_8UC1);
			inRange(frmHsv,Scalar(70, 0, 0),Scalar(85, 255, 255),  rangeRes);
			// <<<<< Color Thresholding
			//imshow("chessboard3",rangeRes);

			// >>>>> Improving the result
			erode(rangeRes, rangeRes,getStructuringElement(MORPH_RECT, Size(7, 7)) );
			dilate(rangeRes, rangeRes,getStructuringElement(MORPH_RECT, Size(7, 7)) );
			//imshow("chessboard4",rangeRes);
			dilate(rangeRes, rangeRes,
						getStructuringElement(CV_SHAPE_RECT, Size(25,1), Point(1,0)));
			erode(rangeRes, rangeRes,
						getStructuringElement(CV_SHAPE_RECT, Size(25,1), Point(1,0)));
			erode(rangeRes, rangeRes,getStructuringElement(MORPH_RECT, Size(9, 9)) );
			dilate(rangeRes, rangeRes,getStructuringElement(MORPH_RECT, Size(9, 9)) );
			//imshow("chessboard5",rangeRes);
			// <<<<< Improving the result

			// >>>>> Contours detection
			vector<vector<cv::Point> > contours;
			cv::findContours(rangeRes, contours, CV_RETR_EXTERNAL,
								 CV_CHAIN_APPROX_NONE);
			// <<<<< Contours detection

			// >>>>> Filtering
			vector<vector<cv::Point> > balls;
			vector<cv::Rect> ballsBox;
			for (size_t i = 0; i < contours.size(); i++)
			{
				cv::Rect bBox;
				bBox = cv::boundingRect(contours[i]);

				float ratio = (float) bBox.width / (float) bBox.height;
				if (ratio > 1.0f)
					ratio = 1.0f / ratio;
				float s = (float) bBox.width * (float) bBox.height;
				float ratioS = s*100/(chessboard.size().width*chessboard.size().height);
				// Searching for a bBox almost square
				if (ratio > 0.75 && bBox.area() >= 400 && ratioS > 0.2)
				{
					balls.push_back(contours[i]);
					ballsBox.push_back(bBox);
				}
			}
			// <<<<< Filtering
			cout << "Balls found:" << ballsBox.size() << endl;

			// >>>>> Detection result
			for (size_t i = 0; i < balls.size(); i++)
			{
				cv::drawContours(Copychessboard, balls, i, CV_RGB(20,150,20), 1);
				cv::rectangle(Copychessboard, ballsBox[i], CV_RGB(0,255,0), 2);

				cv::Point center;
				center.x = ballsBox[i].x + ballsBox[i].width / 2;
				center.y = ballsBox[i].y + ballsBox[i].height / 2;
				cv::circle(Copychessboard, center, 4, CV_RGB(255,0,0), -1);

				stringstream sstr;
				sstr << "(" << center.x << "," << center.y << ")";
				cv::putText(Copychessboard, sstr.str(),
							cv::Point(center.x + 3, center.y - 3),
							cv::FONT_HERSHEY_SIMPLEX, 0.5, CV_RGB(255,0,20), 2);
			}
			// <<<<< Detection result

		imshow("Copychessboard",Copychessboard);
		imshow("OriginalImg",OriginalImg);



		if(waitKey(30) == 27)
		{
			break;
		}
	}

	return 0;
}
