const sqlite3 = require('sqlite3').verbose();
const db = new sqlite3.Database('users.db');

// Create table if not exists
db.serialize(() => {
    db.run(`CREATE TABLE IF NOT EXISTS users (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        username TEXT,
        email TEXT,
        score INTEGER DEFAULT 0
    )`);
});

module.exports = db;

    if (err) {
        console.error('Error connecting to the database:', err.message);
    } else {
        console.log('Connected to the SQLite database.');
    }


module.exports = db;
