Feature: People Equip Weapons
	In order protect myself from zombies
	As a person
	I want to use a weapon

Scenario: Person Equips a Weapon
	Given I have a living person
	And I do not have an equiped weapon
	When I equip a weapon
	Then I should have an active weapon