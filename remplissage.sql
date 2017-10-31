INSERT INTO categories (Nom) VALUE
("cat 1"),
("cat 2");

INSERT INTO question (Question,Reponse_1,Reponse_2,Reponse_3,Bonne,Fkcategories) VALUE
("Question 1","Réponse A","Réponse B","Réponse C",1,(SELECT idCategories FROM categories WHERE Nom = "cat 1")),
("Question 2","Réponse A","Réponse B","Réponse C",2,(SELECT idCategories FROM categories WHERE Nom = "cat 1")),
("Question 3","Réponse A","Réponse B","Réponse C",3,(SELECT idCategories FROM categories WHERE Nom = "cat 1")),
("Question 1","Réponse A","Réponse B","Réponse C",1,(SELECT idCategories FROM categories WHERE Nom = "cat 2")),
("Question 1","Réponse A","Réponse B","Réponse C",2,(SELECT idCategories FROM categories WHERE Nom = "cat 2")),
("Question 1","Réponse A","Réponse B","Réponse C",3,(SELECT idCategories FROM categories WHERE Nom = "cat 2"));
