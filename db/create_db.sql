IF OBJECT_ID('dvd') IS NOT NULL drop table dvd;
IF OBJECT_ID('genre') IS NOT NULL drop table genre;

create table genre
(
    id int not null primary key,
    name varchar(200) not null,
    constraint genre_name_ukey unique(name)
);

create table dvd
(
    id int not null primary key,
    genre int not null,
    title varchar(200) not null,
    releaseyear int,
    description text,
    poster varbinary(max),
    constraint dvd_genre_genre_fkey foreign key (genre) references genre(id)
);

insert into genre(id, name) values(0, 'Action');
insert into genre(id, name) values(1, 'Comedy');
insert into dvd(id, genre, title, releaseyear, description) values(0, 0, 'Aliens', 1987, 'James Cameron');
insert into dvd(id, genre, title, releaseyear, description) values(1, 1, 'Man on the Moon', 1998, 'Jim Carrey');
