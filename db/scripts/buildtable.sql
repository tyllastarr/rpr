CREATE TABLE powerset_powers (
    psPwrId INT NOT NULL AUTO_INCREMENT,
    powerset INT NOT NULL,
    powerId INT NOT NULL,
    levelId INT,

    PRIMARY KEY(psPwrId),

    FOREIGN KEY(powerset) REFERENCES archetype_powersets(atPsId),
    FOREIGN KEY(powerId) REFERENCES powers(powerId)
);