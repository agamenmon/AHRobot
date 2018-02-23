#include <stdio.h>
#include "opencv2/core/core.hpp"
#include "opencv2/highgui/highgui.hpp"

using namespace cv;

int main()
{		
	// Read image
	Mat image = imread("Lena.png", CV_LOAD_IMAGE_COLOR);

	// Check for valid
	if (!image.data)
	{
		printf("Could not open or find the image\n");
		return -1;
	}

	// Create and show image in window	
	imshow("STDIO OpenCV Sample", image);

	// Wait input and exit
	waitKey(0);

	return 0;
}