Feature: People Attack Zombies
	In order to avoid becoming lunch
	As a person
	I want to kill zombies

Scenario: Person Attacks Zombie without a Weapon
	Given I have a living person
	And I do not have an equiped weapon
	And I have an animated zombie
	When I attack a zombie
	Then the zombie should not die

Scenario: Person Attacks Zombie with a Weapon
	Given I have a living person
	And I have an equiped weapon
	And I have an animated zombie
	When I attack a zombie
	Then the zombie should die