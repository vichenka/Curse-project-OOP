   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest  5   	       Test.Registration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Test     5   	     � Title$  Create account��5	       � Icon$" images\icon\Registration.ico��6    � WindowStyle$
 None=�6D   $��462.857��6_   $	��500��6p    � 
ResizeMode$ NoResize=�6|    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5       �� 
TargetType �� Property �� Value	 �� 
TargetType
 J� OpacityMask �� 
StartPoint �� EndPoint � SpreadMethod �� Opacity � Color � Offset �� Triggers P� Property P� Value N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions   Storyboard19  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  '��       &	  �    �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      "	 ��6&   .R�5      � .+�5      �� $��Create��6$   
�������$��Center=�6J   $��Impact)�6g   �� 5      
�������6(   �� 5      #��Z	�6(   ���#841284
 5   "   �� 5   &   HighlightGradient��$	 0,0&�5   !   $	 1,1&�62   $ Reflect=�6A   $	 0.4Q�6X   .��5   *   � $ White��67   $ 0Q�6E   � 5   *   $ Transparent��67   $ 0Q�6K   5   '   5       F� 5!      
�������6#   5"       5#      P� 5$       �@J�IsMouseOver .  5%   "   �� 5&   &   .��5'   *   �� .��5(   .   W� $ HighlightGradient��5)   )   $ GradientStops[0].Offset�5*   )   $ 1X�5+   )   $ 0:0:0.4D�60   5,   /   W� 5-   .   $ HighlightGradient��5.   )   $ GradientStops[1].Offset�5/   )   $ 1X�50   )   $ 0:0:0.3D�60   51   +   52   '    54   "   �� 55   &   .��56   *   �� .��57   .   W� $ HighlightGradient��58   )   $ GradientStops[0].Offset�59   )   $ 0X�5:   )   $ 0:0:0.2D�60   5;   /   W� 5<   .   $ HighlightGradient��5=   )   $ GradientStops[1].Offset�5>   )   $ 0X�5?   )   $ 0:0:0.2D�60   5A   +   5B   '   5D      5F      5H      5I      �� 5K   
   .��5L      U� $ (UIElement.Opacity)�6,   $ textBox��6\   .\�5M        $ 0��6'   $ 1Q�63     5N      $ 0:0:0.6��6'   $ 1Q�69     5O      $ 0:0:1.2��6'   $ 0Q�69   5P      5Q      5S       � Triggers 5U      :� 5V   
    :� RoutedEvent$ TextBoxBase.TextChanged��6    :� 
SourceName$ textBox��6=   .[�5W      ��  �� BeginStoryboardName$! Storyboard1_BeginStoryboard��6   �� 5X      -   5          ��Name$!  Storyboard1_BeginStoryboard��5X      #��[  6C   5Y      ��5\      �� 5]   
   ! �� ImageSource$! images\fon.JPG��6   " j� Stretch$" UniformToFill=�62   # j� TileMode$
# None=�6K   $	 0.5Q�6[   .��5_      � .+�5`   
   �� 
������ $��
10,20,10,0q�6*   $	��516��6>   $	��Top=�6K   ._�5a      �� $��20,20,20,24.4q�6   .+�5b      �� $��Create account��6   
�������$��35(�6D   $��Center=�6R   $��Impact)�6o   $	��450��6�   $��	0,0,-10,0q�6�   �� 5c      -   5        $��login��5c   W   
$ � Tag$$ Login...��6   % �� 	MaxLength$% 20��6)     text#��[ 69   $��0 0 0 1q�6d   
������ 
�������$��25(�6�   $��23,5,0,5q�6�   6�   G� 5d      -   5        & G�Name$& passwordBox��5d      $��0 0 0 1q�63   
�������$��15(�6`   
������ $��	37,30,0,0q�6�   �� 5e      -   5        ' ��Name$' textBox��5e      $% 20��6+   #��[ 6:   $$ Password...��6X   $��Calibri)�6j   $��25(�6   $��0 0 0 1q�6�   
������ $��23,3,0,0q�6�   
�������( J� Opacity$	( 100Q�6P  ��6�   �� ) �� ElementName$) passwordBox��* �� Path$* Password�+ �� Mode$+ TwoWay=�, �� UpdateSourceTrigger$, PropertyChanged=�6P  �� 5f      -   5        - ��Name$- 	ButtomReg��5f      $��0,45,0,0q�6,   $��35(�5h      $��53��6#   5j      5l      �� 5m   
   -   5        $��images/icon/roll_32.png��5m   D   $��432,0,39,428.2q�6f   �� 5n   
   -   5        $��images/icon/close_32.png��5n   @   $��461,0,8,428.2q�6b   �� 5o   
   $��images/icon/user.png��6   $��10,108,446,323.2q�6.   . J� RenderTransformOrigin$. 0.388,0.836&�6H   �� 5p   
   $��images/icon/key_32.png��6   $��10,216,446,216.2q�60   5q      5s      