   M S B A M L   `   `   `  ����C  ?Api_Nasa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Api_Nasa.ViewApi_Nasa.View  5          Api_Nasa.View.PageDaily   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Api_Nasa.View     5      .��5
      � .+�5   
   �� -   5          ��Name$  IMG_FOND��5      $
��Auto��6"   $
��Auto��60   $��\Ressource\Image\Fond.jpg��6=   $
��Fill=�6`   � 5   
    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    .+�5      � -   5        $��	Grid_Haut��5       $��0��6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� -   5         ��Name$ 	LBL_Intro��5      $��0��6+   $%��Bienvenue sur mon application !��6;   
�������$��25(�6x   $
��Bold"�6�   $
��Left=�6�   $	��Top=�6�   �� 5       -   5        $ LBL_Intro_Dev1��5       $p��jVous pouvez parcourir les autres rubriques au dessus pour obtenir des photos
du Rover Curiosity sur Mars !��60   
�������$��16(�6�   $
��Bold"�6�   $
��Left=�6�   $	��Top=�6�   $��	0,130,0,0q�6  �� 5!      -   5        $ LBL_Intro_Dev��5!      $����Cette application se base sur des données fournit par l'API de la NASA 

Vous trouverez sur cette page la photo du jour avec sa description
et d'autres informations connexes.��6/   
�������$��16(�6  $
��Bold"�6  $
��Left=�6'  $	��Top=�6B  $��0,42,0,0q�6Z  �� 5"      -   5        $ 	LBL_Titre��5"      $��1��6+   $��Titre :��6;   
�������$��20(�6`   $
��Bold"�6n   $
��Left=�6�   $��	0,0,0,188q�6�   �� 5#      -   5        $  IMG_APOD��5#      $��1��6*   $
��Auto��6:   $
��Auto��6H   $��	10,44,0,9q�6U   $��\Ressource\Image\apod.jpg��6h   $
��Left=�6�   5$      � 5'      -   5        $��Grid_Bas��5'       $��1��6    5(      �� 5)      $��* �6'   �� 5*      $��* �6'   .+�5/      �� -	   5        $ LBL_Hublle_Intro��5/      $~��xLien vers le site de la Nasa pour voir la photo prise par le télescope spatiale Hubble 
le jour de votre anniversaire !��62   $��0��6�   
�������$��14(�6�   $��DemiBold"�6�   $
��Left=�6�   $��Bottom=�6  $��0,0,0,80q�65  �� 50      -
   5         ��Name$ 
BTN_Hubble��50      $.��(La photo de ton anniversaire c'est ici !��6-   $
��Left=�6`   $��	7,10,0,35q�6{   $��Bottom=�6�   $	��525��6�   $��45��6�      	BleuStyle#��[  6�   $��22(�6�   �� 51      -   5         ��Name$ LBL_Description��51      $��1��65   $��Description :��6E   $
��Bold"�6Z   
�������$��20(�6   $
��Left=�6�   $	��Top=�6�   $
��Wrap=�6�   52      53      54      55      