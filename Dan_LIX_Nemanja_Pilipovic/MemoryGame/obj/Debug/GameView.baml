   M S B A M L   `   `   `  ����E  AMemoryGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MemoryGame
MemoryGame  5   	       MemoryGame.GameView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MemoryGame     5   	     � Title$  GameView��5   	   $	��450��6   $	��340��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $��20 �6   .+�5#   
   �� -   5        $��btnCard1��5#   .   $��1��6   $��1��6!   $��1��6>   $��50��5$      $��50��6   $��Center=�6(   $��10q�5%   P   ��6   �� *Show1+ �� UpdateSourceTrigger$ PropertyChanged=�6P   �� 5'   
   -   5        $��btnCard2��5'   .   $��2��6   $��1��6!   $��2��6>   $��50��5(      $��50��6   $��Center=�6(   $��10q�5)   P   ��6   �� *Show2+$ PropertyChanged=�6P   �� 5+   
   -   5        $��btnCard3��5+   .   $��3��6   $��1��6!   $��3��6>   $��50��5,      $��50��6   $��Center=�6(   $��10q�5-   P   ��6   �� *Show3+$ PropertyChanged=�6P   �� 5/   
   -   5        $��btnCard4��5/   .   $��4��6   $��1��6!   $��4��6>   $��50��6J   $��50��6V   $��Center=�6a   $��10q�50   P   ��6   �� *Show4+$ PropertyChanged=�6P   �� 53   
   -   5        $��btnCard5��53   .   $��1��6   $��2��6!   $��5��6>   $��50��6J   $��50��6V   $��Center=�6a   $��10q�54   P   ��6   �� *Show5+$ PropertyChanged=�6P   �� 56   
   -   5        $��btnCard6��56   .   $��2��6   $��2��6!   $��6��6>   $��50��6J   $��50��6V   $��Center=�6a   $��10q�57   P   ��6   �� *Show6+$ PropertyChanged=�6P   �� 59   
   -   5        $��btnCard7��59   .   $��3��6   $��2��6!   $��7��6>   $��50��6J   $��50��6V   $��Center=�6a   $��10q�5:   P   ��6   �� *Show7+$ PropertyChanged=�6P   �� 5<   
   -   5        $��btnCard8��5<   .   $��4��6   $��2��6!   $��8��6>   $��50��6J   $��50��6V   $��Center=�6a   $��10q�5=   P   ��6   �� *Show8+$ PropertyChanged=�6P   �� 5@   
   -	   5        $��btnCard9��5@   .   $��1��6   $��3��6!   $��9��6>   $��50��6J   $��50��6V   $��Center=�6a   $��10q�5A   P   ��6   �� *Show9+$ PropertyChanged=�6P   �� 5C   
   -
   5        $��	btnCard10��5C   .   $��2��6   $��3��6!   $��10��6?   $��50��6L   $��50��6X   $��Center=�6c   $��10q�5D   Q   ��6   �� *Show10+$ PropertyChanged=�6Q   �� 5F   
   -   5        $��	btnCard11��5F   .   $��3��6   $��3��6!   $��11��6?   $��50��6L   $��50��6X   $��Center=�6c   $��10q�5G   Q   ��6   �� *Show11+$ PropertyChanged=�6Q   �� 5I   
   -   5        $��	btnCard12��5I   .   $��4��6   $��3��6!   $��12��6?   $��50��6L   $��50��6X   $��Center=�6c   $��10q�5J   Q   ��6   �� *Show12+$ PropertyChanged=�6Q   �� 5M   
   -   5        $��	btnCard13��5M   .   $��1��6   $��4��6!   $��13��6?   $��50��6L   $��50��6X   $��Center=�6c   $��10q�5N   Q   ��6   �� *Show13+$ PropertyChanged=�6Q   �� 5P   
   -   5        $��	btnCard14��5P   .   $��2��6   $��4��6!   $��14��6?   $��50��6L   $��50��6X   $��Center=�6c   $��10q�5Q   Q   ��6   �� *Show14+$ PropertyChanged=�6Q   �� 5S   
   -   5        $��	btnCard15��5S   .   $��3��6   $��4��6!   $��15��6?   $��50��6L   $��50��6X   $��Center=�6c   $��10q�5T   Q   ��6   �� *Show15+$ PropertyChanged=�6Q   �� 5V   
   -   5        $��	btnCard16��5V   .   $��4��6   $��4��6!   $��16��6?   $��50��6L   $��50��6X   $��Center=�6c   $��10q�5W   Q   ��6   �� *Show16+$ PropertyChanged=�6Q   5X      5Y      