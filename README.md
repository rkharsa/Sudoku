<h1> Sudoku </h1>
 Conception et Réalisation d'un Sudoku

<h2>Pour Démarrer </h2>
<h3>Langages</h3>
<ul>
	<li>Visual Basic</li>
</ul> 
<h3>Prerequis</h3>
<ul>
<li>Visual Studio 2015 ou ulterieurs</li>
</ul>
<h2>Regles du Jeu</h2>
Le but du jeu est de remplir ces cases avec des chiffres allant de 1 à 9 en veillant toujours à ce qu'un même chiffre ne figure qu'une seule fois par colonne, une seule fois par ligne, et une seule fois par carré de neuf cases.

<h2>Fonctionnalitées</h2>
<ul>
<li>Plusieurs modes de jeu sont proposées
<ul>
<li>facile</li>
<li>intermédiaire</li>
<li>difficile</li>
</ul>
</li>
<li>L'utilisateur a la possibilité de
	<ul>
		<li>Créer ses propres niveaux de sudoku</li>
		<li>Consulter la liste des meilleurs scores</li>
<li>faire des parties avec timer : la partie prendra fin lorsque la timer sera égale  à  0 ou lorsque la grille est remplie
		<li>faire des parties sans timer : la partie prendra fin que lorsque la grille est remplie</li>
	</ul>
	</li>
<li>Differents boutons sont mis en place chacun de ses boutons ont une fonction :
	<ul>
<li>Bouton Play/Pause : Permet de lancer et de mettre en pause le jeu</li>
<li>Bouton Reload : Permet de recommencer la partie</li>
<li>Bouton Clear : Permet de vider la grille de sudoku durant la partie</li>
<li>Bouton Abandonner : Permet de quitter la partie en plein jeu</li>
<li>Sauvegarde des données sur un fichier texte</li>
	</ul>
	</li>
	<li>La Sauvegarde
		<ul>
			<li>Les grilles de sudoku sont  générées à partir de données contenues dans un fichier texte. Lorsqu'un joueur crée une grille de sudoku un fichier texte est généré</li>
			<li> les resultats des joueurs sont également enregistrés dans un fichier texte</li>
		</ul>
	</li>
</ul>
	<h2>Explication de l'algorithmie</h2>
	Le sudoku est basé sur une algorithmie plus ou moins compliquer. je vais vous expliquer comment la detection d'erreur se deroule
	<h3> Verification des Lignes </h3>
	En parametre de la fonction nous avons X (Colonne) ,Y (Ligne) Et value qui correspond a  la valeurs entrer.
	Ensuite une boucle de lecture de tableau a été faite.Cette boucle va faire varier les X  toute en gardant pour constante le Y .En gros on lit les colonnes d'une ligne .
	L'algorithme etant deja tres lourd des conditions ont été mise en place pour limiter le nombre de traitement on verifie : 
	<ul>
	<li>Si la case n'est pas vide  </li>
	<li>Si la colonne ne correspond pas a la colonne envoyé en parametre ,pour eviter de lire la valeur entrer</li>
	<li> Si la  valeurs entrer correspond a une valeurs  de la ligne 
	<ul> 
		<li>Alors on met en rouge la valeurs entrer et la valeurs similaire</li>
	</ul>
	<li>
	</ul>
	<a href="http://zupimages.net/viewer.php?id=18/47/cixj.png"><img src="https://zupimages.net/up/18/47/cixj.png" alt="" /></a>
	<h3> Verification des Colonnes </h3>
		En parametre de la fonction nous avons X (Colonne) ,Y (Ligne) Et value qui correspond a  la valeurs entrer.
	Ensuite une boucle de lecture de tableau a été faite.Cette boucle va faire varier les Y  toute en gardant pour constante le X .En gros on lit les lignes d'une colonne .
	L'algorithme etant deja tres lourd des conditions ont été mise en place pour limiter le nombre de traitement on verifie : 
	<ul>
	<li>Si la case n'est pas vide  </li>
	<li>Si la ligne ne correspond pas a la ligne envoyé en parametre ,pour eviter de lire la valeur entrer</li>
	<li> Si la  valeurs entrer correspond a une valeurs  de la colonne 
	<ul> 
		<li>Alors on met en rouge la valeurs entrer et la valeurs similaire</li>
	</ul>
	<li>
	</ul>
	<h3> Verification des Regions </h3>
	
	<a href="http://zupimages.net/viewer.php?id=18/47/y5c2.png"><img src="https://zupimages.net/up/18/47/y5c2.png" alt="" /></a>
	
