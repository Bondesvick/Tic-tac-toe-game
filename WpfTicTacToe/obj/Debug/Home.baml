   M S B A M L   `   `   `  ����G  CWpfTicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfTicTacToeWpfTicTacToe  5   	       WpfTicTacToe.Home   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfTicTacToe     5   	     � Title$  Tic Tac Toe (Home)��5   	   $	��220��6$   $	��320��61    J� SnapsToDevicePixels .  � 
ResizeMode$ NoResize=�6X    � WindowStartupLocation$ CenterScreen=�6n    � Icon$ Images/033-startup.png��6�    � 	Resources 5	       �� 
TargetType �� Property �� Value��%y   '��       �� 5
      " ��6   .�5   
   ��  � ��
 �����6'   �� 5   
    � ��$	 0.5q�6,   5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��SELECT THE GAME TYPE��6!   $��Center=�6=   $��Center=�6X   $��20(�6u   $��26��6�   $��8,14,8,5q�6�   $	��276��6�   � 5   
   $��1��6   
 � ColumnDefinitions
 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ 
TwoPlayers��5      $��0��6)   $��	2 Players��69   $
��Bold"�6M    � UseLayoutRounding .  6x   �� 5      -   5        $ 	OnePlayer��5      $��1��6(   $��1 Player + Computer��68   $
��Bold"�6V   6h   5      5       5!      