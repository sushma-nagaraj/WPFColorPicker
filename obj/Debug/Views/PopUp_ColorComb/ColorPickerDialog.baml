   M S B A M L   `   `   `  ����I  EWPFColorPicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFColorPickerWPFColorPicker  5      &     WPFColorPicker.ColorPickerDialog   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7WPFColorPickerclr-namespace:WPFColorPicker     5        � 	Resources  5         BrightnessGradient �� 
StartPoint �� EndPoint � ColorInterpolationMode � Offset � Color  OpacityGradient  CheckerboardBrush j� Stretch j� TileMode j� 
AlignmentX	 j� 
AlignmentY
 j� Viewport j� ViewportUnits L� Drawing � Brush � Geometry �� Rect��%h  &	        &	 �     &	 �    �� 5	   
   $	 0,0&�69   $	 1,0&�6J   $ ScRgbLinearInterpolation=�5
   	   .��5      � $ 0Q�6   $ sc# 1, 0,0,0��6&   � 5      $ 1Q�6   $ sc# 1, 1,1,1��6&   5      �� 5   
   $	 0,0&�66   $	 1,0&�6G   $ ScRgbLinearInterpolation=�5   	   .��5      � $ 0Q�6   $ sc# 0, 0,0,0��6&   � 5      $ 1Q�6   $ sc# 1, 0,0,0��6&   5      L� 5   
   $
 None=�5   	   $
 Tile=�6   $
 Left=�6(   $		 Top=�6:   $
 	0,0,10,10�5   	   $ Absolute=�6    5      I� 5      .��5      �  �	sc# 1,1,1 5      �� 5      $ 	0,0,10,10�60   5      � 5       �sc# 0.5,0.5,0.5 5       �� 5!      $ 0,0,5,5�60   5#      � 5$       �sc# 0.5,0.5,0.5 5%      �� 5&      $ 5,5,5,5�60   5(      5)      5+      5,      .��5.      ��  �� Orientation$ Vertical=�6   $	��620��6(   $��10q�64   .+�5/   
   �� $ 
Horizontal=�6   $��0,0,0,11q�6.   .+�50         WPFColorPicker.ColorComb  -   5          Name$ 	colorComb��50   '   $��0,0,10,0q�6:   �� 52      $ Vertical=�6   $	��310��60   .+�53      �� $��Preview��6   $��0q�6,   .��54      ��  �� CornerRadius$ 3��6   #��Z�6.   $��1q�6i   $��5q�6}   #��[ 6�    J� SnapsToDevicePixels . ._�55      �  � RowDefinitions 56      �� 57   "   �� 58   "    � ColumnDefinitions 5:      �� 5;   "   $
��Auto �63   �� 5<   "   $
��100* �63   .+�5>      �� $
��New:��6$   ���#AFFF63   �� 5?      $��Current:��6$   ���#AFFF$��1��6J   �� 5@      -   5        $��stackPanel1��5@   )   $��2��6<   $��1��6M   $��0��6]   .+�5A   "   �� -   5        $��
rectangle1��5A   8   $��38��6,   
���  ��6J   �� 5B   "   -   5        $��
rectangle2��5B   8   $��38��6,   
����  �6J   5C      5D      5E      5F      �� 5G      $��_Brightness��6   $��0,35,0,0q�60   .��5H      �� $ 3��6   #��Z�6.   $��1q�6i   $��5q�6}   #��[  6�    . ._�5I      �� -   5        $��brightnessSlider��5I   !   $��3q�69    �� Orientation$ 
Horizontal=�6D    �� IsMoveToPointEnabled .  � Minimum$	 0.0Q�6y    � Maximum$	 1.0Q�6�   5J      5K      �� 5L      $��_Opacity��6   $��0,7,0,0q�6-   .��5M      �� $ 3��6   #��Z�6.   $��1q�6i   $��5q�6}   #��[ 6�    . ._�5N      �� $��0q�6!   #��[ 6,   ._�5O      �� -   5        $��opacitySlider��5O   %   $��3q�6:   $ 
Horizontal=�6E    . $	 0.0Q�6z   $	 1.0Q�6�   5P      5Q      5R      5S      5U      �� 5W   
   $ 
Horizontal=�6   $��Right=�6.   .+�5X      �� -   5        $��acceptButton��5X       �� 	IsDefault . $��75��6:   $��0,0,9,0q�6H   .��6Y   OK6]   �� 5Y      -   5        $��cancelButton��5Y       �� IsCancel . $��75��69   .��6H   Cancel6P   5Z      5\      5]      