   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest  5   	       
Test.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Test     5   	     � Title$  Login��5	       � Icon$ images\icon\Login.ico��6    � WindowStyle$
 None=�68   $	��510��6S   $	��500��6`    � 
ResizeMode$ NoResize=�6l    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5
         zzz �� 
TargetType �� Property �� Value	 �� 
TargetType
 J� OpacityMask �� 
StartPoint �� EndPoint � SpreadMethod �� Opacity � Color � Offset �� Triggers P� Property P� Value N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions  zz  Storyboard19  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�
  &	        &	 �    &	 �	    �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      "	 ��6&   .R�5      � .+�5      �� $��Log on��6$   
�������$��Center=�6J   $��Impact)�6g   �� 5      
�������6(   �� 5      #��Z	�6(   ���#841284
 5   "   �� 5   &   HighlightGradient��$	 0,0&�5   !   $	 1,1&�62   $ Reflect=�6A   $	 0.4Q�6X   .��5   *   � $ White��67   $ 0Q�6E   � 5   *   $ Transparent��67   $ 0Q�6K   5   '   5      F� 5      
�������6#   5       5       P� 5!       �@J�IsMouseOver .  5"   "   �� 5#   &   .��5$   *   �� .��5%   .   W� $ HighlightGradient��5&   )   $ GradientStops[0].Offset�5'   )   $ 1X�5(   )   $ 0:0:0.4D�60   5)   /   W� 5*   .   $ HighlightGradient��5+   )   $ GradientStops[1].Offset�5,   )   $ 1X�5-   )   $ 0:0:0.3D�60   5.   +   5/   '    51   "   �� 52   &   .��53   *   �� .��54   .   W� $ HighlightGradient��55   )   $ GradientStops[0].Offset�56   )   $ 0X�57   )   $ 0:0:0.2D�60   58   /   W� 59   .   $ HighlightGradient��5:   )   $ GradientStops[1].Offset�5;   )   $ 0X�5<   )   $ 0:0:0.2D�60   5>   +   5?   '   5A      5C      5E      5F      �� 5H   
   " ��6   .�5I      ��  � �� 5J      �� 5K      "	 ��6&   .R�5L      � .+�5M      �� $��Registration��6$   
�������$��Center=�6P   $��Impact)�6m   �� 5N      
�������6(   �� 5O      #��Z	�6(   ���#841284
 5Q   "   �� 5R   &   HighlightGradient��$	 0,0&�5S   !   $	 1,1&�62   $ Reflect=�6A   $	 0.4Q�6X   .��5T   *   � $ White��67   $ 0Q�6E   � 5U   *   $ Transparent��67   $ 0Q�6K   5V   '   5X      F� 5Y      
�������6#   5Z       5[      P� 5\       �@J�IsMouseOver .  5]   "   �� 5^   &   .��5_   *   �� .��5`   .   W� $ HighlightGradient��5a   )   $ GradientStops[0].Offset�5b   )   $ 1X�5c   )   $ 0:0:0.4D�60   5d   /   W� 5e   .   $ HighlightGradient��5f   )   $ GradientStops[1].Offset�5g   )   $ 1X�5h   )   $ 0:0:0.3D�60   5i   +   5j   '    5l   "   �� 5m   &   .��5n   *   �� .��5o   .   W� $ HighlightGradient��5p   )   $ GradientStops[0].Offset�5q   )   $ 0X�5r   )   $ 0:0:0.2D�60   5s   /   W� 5t   .   $ HighlightGradient��5u   )   $ GradientStops[1].Offset�5v   )   $ 0X�5w   )   $ 0:0:0.2D�60   5y   +   5z   '   5|      5~      5�      5�      �� 5�   
   .��5�      U� $ (UIElement.Opacity)�6,   $ password��6\   .\�5�        $ 0��6'   $ 1Q�63     5�      $ 0:0:0.6��6'   $ 1Q�69     5�      $ 0:0:1.2��6'   $ 0Q�69   5�      5�      5�       � Triggers 5�      :� 5�   
    :� RoutedEvent$ TextBoxBase.TextChanged��6   .[�5�      ��  �� BeginStoryboardName$! Storyboard1_BeginStoryboard��6   �� 5�      -   5         ��Name$! Storyboard1_BeginStoryboard��5�      #��[ 6C   5�      ��5�      �� 5�   
     �� ImageSource$  images\fon3.JPG��6   ! j� Stretch$! UniformToFill=�63   " j� TileMode$
" None=�6L   $	 0.5Q�6\   .��5�      � .+�5�   
   �� 
������ $��10,20,10,24.4q�6*   ._�5�      �� $��20,20,20,24.4q�6   .+�5�      �� $��Log on��6   
�������$��35(�6<   $��Center=�6J   $��Impact)�6g   $	��450��6{   $��	0,0,-10,0q�6�   �� 5�      -   5        # ��Name$# login��5�   H   
$ � Tag$$ Login...��6     text#��[ 6*   $��0 0 0 1q�6W   % �� 	MaxLength$% 20��6q   $��Calibri)�6�   
�������
������ $��25(�6�   $��	27,20,0,0q�6�   6�   G� 5�      -   5        $��passwordBox��5�      $��0 0 0 1q�61   
�������$��15(�6^   
������ $��	30,35,0,0q�6�   $��39��6�   �� 5�      -   5        $��password��5�      $% 20��6*   #��[ 69   $$ Password...��6W   $��Calibri)�6i   $��25(�6~   $��0 0 0 1q�6�   
������ $��30,3,0,0q�6�   
�������& J� Opacity$	& 100Q�6O  ��6�   �� ' �� ElementName$' passwordBox��( �� Path$( Password�) �� Mode$) TwoWay=�* �� UpdateSourceTrigger$* PropertyChanged=�6O  �� 5�      -   5        + ��Name$+ 	ButtomLog��5�      $��0,45,0,0q�6,   #��[  6>   $��35(�5�      �� 5�      -   5        $+ ButtomR��5�      $��0,16,0,0q�6*   #��[ 6=   $��35(�5�      $��48��6#   5�      5�      �� 5�   
   -   5        $��images/icon/roll_32.png��5�   D   $��20��6e   $��20��6q   $��448,8,32,482.4q�6|   �� 5�   
   -   5        $��images/icon/close_32.png��5�   @   $��20��6b   $��20��6n   $��465,0,0,475.4q�6y   �� 5�   
   $��images/icon/user.png��6   $��28,127,447,358.4q�6.   $��25��6H   $��25��6S   , J� RenderTransformOrigin$, 0.388,0.836&�6_   �� 5�   
   $��images/icon/key_32.png��6   $��28,194,447,291.4q�60   $��25��6J   $��25��6U   5�      5�      