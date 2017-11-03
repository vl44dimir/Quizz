USE quizz;
INSERT INTO categories (Nom) VALUE
("Math"),
("Programmation"),
("Culture Général");

INSERT INTO question (Question,Reponse_1,Reponse_2,Reponse_3,Bonne,Fkcategories) VALUE
("Combien font 3 * 3 ?","6","9","12",2,(SELECT idCategories FROM categories WHERE Nom = "Math")),
("Quelle est le langage de programmation qui n’existe pas ?","C","C++","C--",3,(SELECT idCategories FROM categories WHERE Nom = "Programmation")),
("Quelle Marque à une pomme comme logo ?","Apple","Microsoft","Linux",1,(SELECT idCategories FROM categories WHERE Nom = "Culture Général")),
("Quand le premier Iphone est sortie ?","2006","2007","2017",2,(SELECT idCategories FROM categories WHERE Nom = "Culture Général")),
("Quelle entreprise a créé Cortana ?","Apple","Microsoft","Linux",2,(SELECT idCategories FROM categories WHERE Nom = "Culture Général")),
("Quelle est la valeur de PI arrondi à deux chiffres ?","3.14","3.13","3.15",1,(SELECT idCategories FROM categories WHERE Nom = "Math")),
("Que fait la ligne de code suivante : mavariable++ ??","Incrémente la variable 'mavariable' de 1","Décrémente la variable 'mavariable' de 1","Ne fait rien",1,(SELECT idCategories FROM categories WHERE Nom = "Programmation")),
("En quelle année le Titanic a coulé ?","1911","1912","1913",2,(SELECT idCategories FROM categories WHERE Nom = "Culture Général")),
("En quelle année a été adopté le drapeau actuel de la suisse ?","1840","1841","1842",1,(SELECT idCategories FROM categories WHERE Nom = "Culture Général")),;
