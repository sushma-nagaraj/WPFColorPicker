   M S B A M L   `   `   `  ����I  EWPFColorPicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFColorPickerWPFColorPicker  5      %    WPFColorPicker.ColorPickerView1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7WPFColorPickerclr-namespace:WPFColorPicker     5        � 	Resources  5	         toggleButtonStyle �� 
TargetType �� Property  ButtonFocusVisual1 �� Value  ButtonNormalBackgroundFill1 �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName��%g  &	        7  7  �� 5
   
   " d�6*   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��# � ��6+   �� 5       � ��$ Right=�64   �� 5       � ��$ Bottom=�62   �� 5       � �� 5      �� 5      " d�6&   .R�5      �� $ buttonBorder��6!   $
��Auto��67   $
��Auto��6E   ._�5      �� # z 6/   #��z��6k   #��z��5      #��z��6@   ��. $��36.625��6�   5       5      P� 5       � {�	 .  . �5   "   �� # � ��6?    � ��5      P� 5       �@d�	IsChecked$
	 TrueY�6;   . �5   "   �� # � ��6?    � ���� 5   "   $
 buttonBorder��6X    � ��$ 1.5,1.5,0,0q�6D   6X   �� 5   "   $
 buttonBorder��6Q    � ��
 ������� 5   "   $
 buttonBorder��6Q    � ��
 �����5       5"      5$      5%      5&      .��5'      � .+�5(   
   d� -   5         d�Name$ ColorButton��5)      #��[  5*      $��0.5,0.5,0.5,0.5q�5+      ���	#FF000000$��15��5-      $��15��6   $��0q�6$   $
��Left=�5.      $	��Top=�6(   $��2,0,0,0q�5/      ��5.   @   ��  �� ElementName$ colorPalette�� �� Path$ CurrentColor�.��50      �� .+�51      �� $$��../../Resources/colorChart.png��6    J� OpacityMask
 �   �6@   �� 52      -   5        $ ColorBorder��53      |�.  $��15��56      $��1,1,1,1q�6   ���#b4b4b5$��15��6M   ��55      �� $ CurrentColor�._�57      �� $��7��6   $��7��6'   $��0,0,0,0q�62   ���	#FFFFFFFF$��Right=�6z   $��Bottom=�6�   ��6L   Z� ._�58      F� $	��4.5��6   $��3.839��6+   ���	#FF000000 �� Stretch$
 Fill=�6K   ���	#FF000000@���0�S�Y���y-=�޿sm�|�@u��C�޿�t}Z�?�"���@	6m   59      5:      5;      5<      � 5>   
   -   5         �Name$ popup��5>       � 	StaysOpen .   � AllowsTransparency . |�. $
��Fade=�5B      $��Bottom=�5C       .  � PlacementTarget 5E      �� $ ColorButton����5F      �� $ 	IsChecked�$ ColorButton��.��5G         WPFColorPicker.PopUp1  -   5          Name$ colorPalette��5G   $   6<   5H      5I      5J      