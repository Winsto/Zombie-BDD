Feature: Zombies Eat People
	In order to quench an unending hunger for human flesh
	As a zombie
	I want to eat people

Scenario: Zombie Eats a Person
	Given I have an animated zombie
	And I have a living person
	When I eat a person
	Then the person should die
