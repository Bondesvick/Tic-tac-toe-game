   M S B A M L   `   `   `  ����G  CWpfTicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfTicTacToeWpfTicTacToe  5   	       WpfTicTacToe.OnePlayer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfTicTacToe     5   	     � Title$&   Tic Tac Toe(1 Player + Computer)��5   	   $	��500��62   $	��500��6?    J� SnapsToDevicePixels .  � 
ResizeMode$ NoResize=�6f    � WindowStartupLocation$ CenterScreen=�6|    � Icon$ Images/033-startup.png��6�    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$	 0.5q�60   �� 5       � ��$ 70(�6)   5      5      .��5      � -   5        	 �Name$	 	Container��5      
 � ColumnDefinitions
 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	Button0_0��5      
 J� Uid$ 0��6$   $��0��6,   $��0��6<   6I   �� 5   
   -   5        $ 	Button1_0��5      $ 1��6$   $��1��6-   $��0��6=   6J   �� 5    
   -   5        $ 	Button2_0��5       $ 2��6$   $��2��6,   $��0��6<   6I   �� 5"   
   -   5        $ 	Button0_1��5"      $ 3��6$   $��0��6,   $��1��6<   6I   �� 5#   
   -   5        $ 	Button1_1��5#      $ 4��6$   $��1��6,   $��1��6<   6I   �� 5$   
   -   5        $ 	Button2_1��5$      $ 5��6$   $��2��6,   $��1��6<   6I   �� 5&   
   -   5        $ 	Button0_2��5&      $ 6��6$   $��0��6,   $��2��6<   6I   �� 5'   
   -	   5        $ 	Button1_2��5'      $ 7��6$   $��1��6,   $��2��6<   6I   �� 5(   
   -
   5        $ 	Button2_2��5(      $ 8��6$   $��2��6,   $��2��6<   6I   5*      5+      