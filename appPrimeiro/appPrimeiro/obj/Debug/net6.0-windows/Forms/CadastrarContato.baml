   M S B A M L   `   `   `  ����F  BappPrimeiro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:appPrimeiroappPrimeiro  5   	   "    appPrimeiro.CadastrarContato   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:appPrimeiro     5   	     � Title$  CadastrarContato��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   �� $��Cadastrar Contatos��6   $
��Left=�6-   $��
264,30,0,0q�6H   $	��Top=�6\   $��37��6t   $	��224��6�   $��Arial)�6�   $��22(�6�   $
��Bold"�6�   ��6�   Z� �� 5   
   -   5         ��Name$ txtNome��5      $
��Left=�6#   $��
82,112,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��214��6~   $��Arial)�6�   $��16(�6�   $��27��6�   ���	#FF0061FF6�   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��
83,312,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��214��6   $��Arial)�6�   $��16(�6�   $��31��6�   ���	#FF0061FF6�   �� 5   
   -   5        $ txtTelefone��5      $
��Left=�6'   $��455,231,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��214��6�   $��29��6�   $��Arial)�6�   $��16(�6�   ���	#FF0061FF6�   �� 5   
   $
��Nome��6   $
��Left=�6   $��	82,79,0,0q�6:   $	��Top=�6M   $��16(�6e   $��Arial)�6s    J� RenderTransformOrigin$ 
0.62,0.121&�6�   $
��Bold"�6�   �� 5   
   $��Email��6   $
��Left=�6    $��
84,275,0,0q�6;   $	��Top=�6O   $��Arial)�6g   $��16(�6z   $
��Bold"�6�   �� 5   
   $��	Telefone:��6   $
��Left=�6$   $��454,198,0,0q�6?   $	��Top=�6T   $��Arial)�6l   $��16(�6   $
��Bold"�6�   �� 5   
   ���	#FF0056FF$��2,2,2,2q�6)   $
��Left=�6C   $��65��6^   $��
81,189,0,0q�6j   $	��Top=�6~   $	��214��6�   �� 5   
   $��Sexo:��6   $
��Left=�6    $��
81,149,0,0q�6;   $	��Top=�6O   $��Arial)�6g   $��16(�6z   $
��Bold"�6�   �� 5   
   -   5        $��Salvar��5      $
��Left=�6"   $��612,345,0,0q�6=   $	��Top=�6R   $��48��6j   $	��117��6v   $��Arial)�6�   $��16(�6�   $
��Bold"�6�   
�������
���   ����	#FF0033FF$��2,2,2,2q�6�   6  	� 5   
   -   5         	�Name$ rdSexo1��5      $��Feminino��6'   $
��Left=�6:   $��
87,201,0,0q�6U   $	��Top=�6i   $��Arial)�6�   $��16(�6�   $	��103��6�   $��22��6�   $��1,1,1,1q�6�   ���	#FF0061FF6�   	� 5   
   -   5        $ rdSexo2��5      $��	Masculino��6'   $
��Left=�6;   $��
87,223,0,0q�6V   $	��Top=�6j   $��Arial)�6�   $��16(�6�   ���	#FF0061FF6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateDataNascimento��5      $
��Left=�61   $��456,121,0,0q�6L   $	��Top=�6a   $��28��6y   $	��182��6�   ���	#FF0010FF$��16(�6�   �� 5   
   $��Data de Nascimento��6   $
��Left=�6-   $��
454,88,0,0q�6H   $	��Top=�6\   $��16(�6t   $��Arial)�6�   $ 
0.62,0.121&�6�   $
��Bold"�6�   5      5      