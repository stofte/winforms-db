IF OBJECT_ID('dvd') IS NOT NULL drop table dvd;
IF OBJECT_ID('genre') IS NOT NULL drop table genre;

create table genre
(
    id int not null primary key IDENTITY,
    name varchar(200) not null,
    constraint genre_name_ukey unique(name)
);

create table dvd
(
    id int not null primary key IDENTITY,
    genre int not null,
    title varchar(200) not null,
    releaseyear int,
    description text,
    poster varbinary(max),
    constraint dvd_genre_genre_fkey foreign key (genre) references genre(id)
);

insert into genre(name) values('Action');
insert into genre(name) values('Comedy');

insert into dvd(genre, title, releaseyear, description) values(1, 'Aliens', 1987, 'James Cameron');
insert into dvd(genre, title, releaseyear, description) values(2, 'Man on the Moon', 1998, 'Jim Carrey');
