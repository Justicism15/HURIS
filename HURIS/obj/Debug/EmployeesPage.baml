   M S B A M L   `   `   `  ����@  <HURIS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HURISHURIS  5          HURIS.Employees   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      localclr-namespace:HURIS  5        N� Title$  Test123��5	       N� 
Background �	#FFF7F7F7$	��500��6.   $	��800��6=   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!    � RowDefinitions 5   
   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5       $��35 �6   6*   �� 5!      $��35 �6   6*   �� 5"      $��35 �6   6*   �� 5#      $��35 �6   6*   �� 5$      $��35 �6   6*   �� 5%      $��35 �6   6*   .+�5E   
   �� $��0 0 0 1q�6   
�������$��0��6>   $��2��6K   ���	#FFDAD9D9._�5F      ��  �� Orientation$ 
Horizontal=�6   .+�5G      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ PeopleOutline=�6*   ���	#FF2CC56C$��73��6V   $��50��6a   $��	40,10,0,0q�6m   �� 5H      $��	EMPLOYEES��6   $��25(�6,   $��0,13,0,9q�6:   $��Roboto)�6L   5J      5M      �� 5N   
   $��3��6   $��16��6   $��	43,0,49,0q�61   $��Stretch=�6D   $��Stretch=�6`   $	��900��6~   $	��490��6�   ���	#FFBFBDBD �� CornerRadius$ 3,3,3,3��6�   $��1q�6�   ._�5O      �� $	��Top=�6   ���#273746$��2,0,0,0q�6F   $��58��6W   .+�5P      � $��	-38,0,0,0q�6    5Q      �� 5R      6-   �� 5S      6-   .+�5V      �� -   5         ��Name$ btnAddEmployee��5V      $��1��65   $��
0,10,10,17q�6E   $��0q�6r   ���	#FFD1D1D1$��Right=�6�   $	��120��6�   $��Raleway ExtraBold)�6�   ��5W      �� 5X      .R�5Y   "   �� $ 2��6)   ���	#FFE0DDDD���	#FF5499C7$��37��6i   ._�5Z   &   ]� $��0,0,10,0q�60   .+�5[   *     $ 	AddCircle=�6B   $��15��6S   $��15��6^   
�������$
��8 10q�6}   �� 5\   *   $��center=�64   
�������$��-5,12q�6b   $��91��6q   $��10.667(�6|   ADD EMPLOYEE5]   +   5^   '   5`   #   5a      5d      �� 5g      $
��Left=�6   $��20(�67   $��EMPLOYEE LIST��6E   
�������$��
Montserrat)�6p   $��
56,10,0,10q�6�   5h      5i      5j      �� 5k   
   $��0,0,49,0q�6   $ 
Horizontal=�6(   $��5��6B   $��Right=�6O   $	��397��6k   .+�5l      �� $��.7q�6   ���	#FFC1BBBB �� Padding$	 0 5q�6C   $��	15,0,10,5q�6Q   $	��235��6d   ._�5m      �� -   5        	 ��Name$	 	txtSearch��5m      $��0q�6-   $
��Left=�6A   $	��350��6\   $��4,-1,-120,0q�6h   ��6}   Z� .��6�   5o      5p      �� 5q      -   5        $ 	btnSearch��5q      $��0q�6(   ���	#FFD1D1D1$��Right=�6S   $	��129��6o   ���	#FFC7C3C3
 � ForceCursor
 . $��0,0,0,5q�6�   $��Raleway ExtraBold)�6�   ��5r      �� 5s      .R�5t      �� $ 10��6!   ���	#FFE0DDDD���	#FFDAD7D7._�5v      �� $	��0 8q�6(   $��Center=�65   $��SEARCH��6S   $��Raleway ExtraBold)�6a   $��10.667(�6�   5w      5x      5z      5{      &   System.Windows.Controls.DataGrid  5}   
   -   5        $��dataGridView1��5}      $	��900��6(   $	��450��67   $��6��6H   $��13��6U   $��Stretch=�6g   $��Stretch=�5~      $ �� IsSynchronizedWithCurrentItem$ FalseY�6'   $��	43,0,49,0q�6d      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         RowBackground �#F2F3F4   AlternatingRowBackground
 �����   CanUserAddRows .     SelectionMode$ Extended=�6l      GridLinesVisibility$
 None=�6�   
�������   ColumnHeaderHeight$ 30Q�6,     HeadersVisibility$ Column=�6D  ��5~   M   Z�    HorizontalGridLinesBrush 5   �   Z�    VerticalGridLinesBrush 6
  Z�    Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn   HeaderTemplate 5�      �� 5�      .R�5�      �� 
����� �
�������6M   5�         CellTemplate 5�      �� 5�      .R�5�      �� $��Center=�6*   $ 
Horizontal=�6G    J� Opacity$ 1Q�6a   .+�5�   "   �� $ btnEdit��6)   -   5        $
��Edit��5�   :   $��0q�6Y   $��70��6m   $��30��6{   ���	#FFD1D1D1$��Stretch=�6�   $
��10 0q�6�   
 . $ 1Q�6�   6�   5�      5�      5�      5�      5�      5�      