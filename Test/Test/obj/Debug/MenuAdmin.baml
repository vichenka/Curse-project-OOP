   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest  5   	       Test.MenuAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FWpfAnimatedGif, Version=1.4.15.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   
   localclr-namespace:Test  5   	     � Title$
  Menu��5
   	    � Icon$ images\icon\quest.ico��6    � WindowStyle$
 None=�64   $	��540��6O   $	��550��6\    � 
ResizeMode$ NoResize=�6h    � WindowStartupLocation$ CenterScreen=�6~   ��5      �� 5   
    �� ImageSource$ images\fon3.JPG��6    j� Stretch$ UniformToFill=�63    j� TileMode$
 None=�6L    �� Opacity$	 0.5Q�6\   .��5      � .+�5   
   �� 
������ $��10,20,10,24.4q�6*   ._�5      ]� .+�5      �� $
��Menu��6   
�������$��35(�6:   $��Center=�6H   $��Impact)�6e   $	��450��6y   $��
5.,0,-10,0q�6�   �� 5      -   5        $
��text��5      "	 �� VerticalScrollBarVisibility$
	 Auto=�6&   
 �� 
IsReadOnly
 .  �� TextWrapping$
 Wrap=�6[    �� AcceptsReturn . $��Hello Administrator��6�   $��Calabri)�6�   $��23(�6�      text#��[  5      $��1 1 1 1q�68   
�������$��-180,150,-14,289q�5      $	��237��64   
������ 6@   �� 5      ���	#FFF0DFF0$	��217��64   $��-1100,90,0,82q�6@   ��5      �� 5       �� 
TargetType" ��6     �� Triggers 5      :� 5   "    :� RoutedEvent$ 
MouseEnter��6/   [�5   &   �� 5   *   .��5    .   �� .��5!   2   t�  �� TargetProperty$ Margin�6E    t� From$ -1100 90 0 82X�6h   	 t� To$ -750 90 0 82X�6}    g� DecelerationRatio$ .9Q�6�    g� Duration$ 0:0:0.7D�6�   5"   /   5#   +   5%   #   :� 5&   "   $ 
MouseLeave��6/   [�5'   &   �� 5(   *   .��5)   .   �� .��5*   2   t� $ Margin�6E   $ -750 90 0 82X�6h   $ -1100 90 0 82X�6|   $ .9Q�6�   $ 0:0:0.10D�6�   5+   /   5,   +   5.   #   50      .+�52      ]� $��Center=�6    $��Center=�6;   .+�53      �� -   5         ��Name$ label1��53       $��Impact)�54       $
��Test��58       $��30(�59       $	��150��5:       
�������$��59��5;   3   �� 5<      $��images/menu_32.png��6    $��36��6<   $��35��6G   5=      �� 5>      $��13,2,53.6,2q�6    ���#951ba36L   ]� 5?      $��Center=�6    $��Center=�6;   .+�5@      �� -   5        $ label2��5@        � ToolTip$ 
Тесты��60   $��Calibri)�5A       $��Tests��5E       $��20(�5F       $	��150��5G       
�������5H       5J      ]� 5L      $��Center=�6    $��Center=�6;   .+�5M      �� -   5        $ label5��5M       $1 +Удаление пользователей��63   $��Calibri)�5N       $��Delete user��5R       $��20(�5S       $	��150��5T       
�������5U       5W      ]� 5Z      $��Center=�6    $��Center=�6;   .+�5[      �� -   5        $ label7��5[       $ О программе��62   $��Calibri)�5\       $��About��5`       $��20(�5a       $	��150��5b       
�������5c       5d      ]� 5e      $��Center=�6    $��Center=�6;   .+�5f      �� -   5        $ label8��5f       $ 
Выйти��62   $��Calibri)�5g       $
��Exit��5k       $��20(�5l       $	��150��5m       
�������5n       5o      5q      5r      5s      �� 5t   
   -   5        $��images/icon/roll_32.png��5t   D   $��20��6e   $��20��6q   $��503,8,28.4,512q�6}   �� 5u   
   -   5        $��images/icon/close_32.png��5u   @   $��20��6b   $��20��6n   $��515,0,0.4,505q�6z   �� 5v   
   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ images/helo.gif��6    J� Opacity$	 0.8Q�6C   $��239,232,0.4,24q�6Q   5x      5y      