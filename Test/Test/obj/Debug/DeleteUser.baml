   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest  5   	       Test.DeleteUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Test     5   	     � Title$  
DeleteUser��5   
    � Icon$ images\icon\quest.ico��6    � WindowStyle$
 None=�6;   $	��540��6V   $	��550��6c    � 
ResizeMode$ NoResize=�6o    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5	         zzz �� 
TargetType �� Property �� Value	 �� 
TargetType
 J� OpacityMask �� 
StartPoint �� EndPoint � SpreadMethod �� Opacity � Color � Offset �� Triggers P� Property P� Value N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions��%�  &	        �� 5
   
   " ��6   .�5      ��  � �� 5      �� 5      "	 ��6&   .R�5      � .+�5      �� $��Delete��6$   
�������$��Center=�6J   $��Impact)�6g   �� 5      
�������6(   �� 5      #��Z	�6(   ���#841284
 5   "   �� 5   &   HighlightGradient��$	 0,0&�5   !   $	 1,1&�62   $ Reflect=�6A   $	 0.4Q�6X   .��5   *   � $ White��67   $ 0Q�6E   � 5   *   $ Transparent��67   $ 0Q�6K   5   '   5      F� 5      
�������6#   5       5      P� 5       �@J�IsMouseOver .  5   "   �� 5    &   .��5!   *   �� .��5"   .   W� $ HighlightGradient��5#   )   $ GradientStops[0].Offset�5$   )   $ 1X�5%   )   $ 0:0:0.4D�60   5&   /   W� 5'   .   $ HighlightGradient��5(   )   $ GradientStops[1].Offset�5)   )   $ 1X�5*   )   $ 0:0:0.3D�60   5+   +   5,   '    5.   "   �� 5/   &   .��50   *   �� .��51   .   W� $ HighlightGradient��52   )   $ GradientStops[0].Offset�53   )   $ 0X�54   )   $ 0:0:0.2D�60   55   /   W� 56   .   $ HighlightGradient��57   )   $ GradientStops[1].Offset�58   )   $ 0X�59   )   $ 0:0:0.2D�60   5;   +   5<   '   5>      5@      5B      5C      5D      ��5E      �� 5F   
    �� ImageSource$ images\fon3.JPG��6    j� Stretch$ UniformToFill=�63    j� TileMode$
 None=�6L   $	 0.5Q�6\   .��5H      � .+�5I   
   �� 
������ $��10,10,10.4,24q�6*   ._�5K      �� -   5         ��Name$ Daock��5K      $��0,0,0.6,9.6q�6(   .+�5N      �� $��User's name��6   
�������$��35(�6A   $��Impact)�6O   $��162,30,161.6,0q�6c   �� 5O      -   5         ��Name$
 list��5O      $��Visible=�6(   $��24(�6[   
����������	#334C3535$	��278��6�   $��120,6,121.6,-1.2q�6�   $��0q�6�   $	��323��6�   �� 5P      -   5         ��Name$ 	ButtomLog��5P        � ToolTip$-  'Удалить пользователя��6,   #��[  6K   $��45(�5R      $��125,16,126.6,215.8q�6#   5T      5U      �� 5V   
   -   5        $��20��5V   D   $��20��6P   $��images/icon/Back.png��6[   $��486,8,44.4,512q�6y   �� 5W   
   -   5        $��20��5W   D   $��20��6P   $��images/icon/roll_32.png��6[   $��506,8,24.4,512q�6|   �� 5X   
   -   5        $��20��5X   @   $��20��6L   $��images/icon/close_32.png��6W   $��526,8,4.4,512q�6y   5Y      5Z      