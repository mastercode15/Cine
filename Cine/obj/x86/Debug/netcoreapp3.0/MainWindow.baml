   M S B A M L   `   `   `  ����?  ;Cine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CineCine  5   	       Cine.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Cine     5   	     � Title$  
MainWindow��5   	   $	��573��6   $	��936��6)    � 	Resources 5	         Stop��%�   &	        �� 5
   
   $_��YC:\Users\Sebastian\OneDrive\Escritorio\prototipo_cine\Cine\Images\asientoSeleccionado.png��6   $��51��6�   $��5��6�   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��467* �6   �� 5      .+�5   
   �� $
��Left=�6   $Q��KC:\Users\Sebastian\OneDrive\Escritorio\prototipo_cine\Cine\Images\cine1.jpg��6,   $	��272��6�   $��0,1,0,0q�6�   $	��Top=�6�   $	��461��6�   �� 5   
   $
��Left=�6   $T��NC:\Users\Sebastian\OneDrive\Escritorio\prototipo_cine\Cine\Images\pantalla.png��6,   $��37��6�   $��520,253,0,0q�6�   $	��Top=�6�   $	��331��6�   �� 5   
   $��Atrás��6   $
��Left=�6!   $��
70,310,0,0q�6<   $	��Top=�6P   $��40��6h   $��89��6t   �� 5   
   $��	Continuar��6   $
��Left=�6%   $��630,313,0,0q�6@   $	��Top=�6U   $��40��6m   $��89��6y   �� 5   
   $
��Left=�6   $��19��6/   $��280,310,0,0q�6;   $��1 Asiento seleccionado��6P   $
��Wrap=�6n   $	��Top=�6�   $	��140��6�   �� 5   
   -   5        $��buttonPlay0��5   M   $��60��6   $
��Left=�6   $��573,107,0,0q�68   $	��Top=�6`   $��75��6x   ��6�   �� *PlayCommand+��6�   ��  �� ElementName$ ButtonImage0�� �� Path$ Source�.��5      �� -   5        $��ButtonImage0��5      ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5        �� Binding 6*   �� *	isPlaying+ �� Value True6H   .a�5!   "   �� 	 �� Property	 � ��
 �� Value$a
 [C:\Users\Sebastian\OneDrive\Escritorio\prototipo_cine\Cine\Images\asientoDeseleccionado.png��6;   5"      �� 5#       6*   �� *	isPlaying+	 False6H   .a�5$   "   �� 	 � ��$_
 YC:\Users\Sebastian\OneDrive\Escritorio\prototipo_cine\Cine\Images\asientoSeleccionado.png��6;   5%      5'      5)      5*      5,      5-      