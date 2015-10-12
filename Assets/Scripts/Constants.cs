using System;
namespace Utils
{
	public class Constants
	{
		public static int MIN_YPOS = -13 ;
		public static int MAX_YPOS = -MIN_YPOS ;

		public static int MIN_XPOS = int.Parse( PLAYER_XPOS + "" ) ;
		public static int MAX_XPOS = -MIN_XPOS ;

		public static float PLAYER_XPOS = -22 ;
		public static float ENEMY_XPOS = -PLAYER_XPOS ;

		public static float BALL_VELOCITY = 1000 ;

		public static float ENEMY_SPEED = 4 ;

		public static float PLAYER_SPEED = 1 ;
	}
}