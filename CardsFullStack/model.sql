﻿create database CardGame;
use CardGame;

create table Deck (
    deck_id varchar(20),
    is_current boolean,
    created_at datetime,
    username varchar(20),
    primary key (deck_id)
);

create table Card (
	id int not null auto_increment,
    deck_id varchar(20),
    image varchar(200),
    cardcode char(2),
    username varchar(20),
    created_at datetime,
    primary key (id)
)