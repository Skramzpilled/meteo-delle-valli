namespace taizzor
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerca = new ReaLTaiizor.Controls.LostCancelButton();
            this.hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            this.dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.hopePictureBox3 = new ReaLTaiizor.Controls.HopePictureBox();
            this.lostCancelButton1 = new ReaLTaiizor.Controls.LostCancelButton();
            this.lostCancelButton2 = new ReaLTaiizor.Controls.LostCancelButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 47);
            this.label1.TabIndex = 54;
            this.label1.Text = "IL METEO DELLE VALLI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btncerca
            // 
            this.btncerca.BackColor = System.Drawing.Color.SeaGreen;
            this.btncerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btncerca.ForeColor = System.Drawing.Color.White;
            this.btncerca.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btncerca.Image = null;
            this.btncerca.Location = new System.Drawing.Point(116, 554);
            this.btncerca.Name = "btncerca";
            this.btncerca.Size = new System.Drawing.Size(167, 40);
            this.btncerca.TabIndex = 56;
            this.btncerca.Text = "CERCA";
            this.btncerca.Click += new System.EventHandler(this.btncerca_Click);
            // 
            // hopePictureBox2
            // 
            this.hopePictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox2.Location = new System.Drawing.Point(458, 148);
            this.hopePictureBox2.Name = "hopePictureBox2";
            this.hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox2.Size = new System.Drawing.Size(400, 400);
            this.hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox2.TabIndex = 59;
            this.hopePictureBox2.TabStop = false;
            this.hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // dungeonComboBox1
            // 
            this.dungeonComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dungeonComboBox1.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.dungeonComboBox1.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.dungeonComboBox1.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.dungeonComboBox1.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dungeonComboBox1.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.dungeonComboBox1.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dungeonComboBox1.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.dungeonComboBox1.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.dungeonComboBox1.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dungeonComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dungeonComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dungeonComboBox1.DropDownHeight = 100;
            this.dungeonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dungeonComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dungeonComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.dungeonComboBox1.FormattingEnabled = true;
            this.dungeonComboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.dungeonComboBox1.IntegralHeight = false;
            this.dungeonComboBox1.ItemHeight = 20;
            this.dungeonComboBox1.Items.AddRange(new object[] {
            "Alba di Canazei",
            "Bansko",
            "Klausberg",
            "4 Vallees",
            "Abetone",
            "Adelboden",
            "Airolo",
            "Ala Di Stura",
            "Alagna Valsesia",
            "Alleghe",
            "Alpe Campo Rimasco",
            "Alpe Cermis",
            "Alpe Cialma Locana Canavese",
            "Alpe d\'Huez",
            "Alpe Devero",
            "Alpe di Mera",
            "Alpe di Siusi",
            "Alpe Giumello",
            "Alta Badia",
            "Alta Pusteria",
            "Altopiano di Asiago",
            "Andalo",
            "Andermatt",
            "Antagnod",
            "Anterselva Rasun",
            "Aprica",
            "Arabba",
            "Åre",
            "Argentera",
            "Arioso Fossa Cupa",
            "Arlberg",
            "Arosa",
            "Artesina",
            "Aspen Snowmass",
            "Auronzo di Cadore",
            "Aussois",
            "Avoriaz",
            "Bad Gastein",
            "Bad Kleinkirchheim",
            "Baitina di Druogno",
            "balze",
            "Baqueira Beret",
            "Bardonecchia",
            "Beaver Creek",
            "Bellino",
            "Belpiano",
            "Bettmeralp Aletsch Arena",
            "Bielmonte",
            "Bionaz Valpelline",
            "Bobbio Passo Penice",
            "Bocca della Selva",
            "Bolbeno",
            "Bolognola",
            "Bormio",
            "Borno",
            "Bovec",
            "Brallo",
            "Bremboski",
            "Breuil Cervinia",
            "Brunico",
            "Brusson",
            "Cainallo vicinanze",
            "Caldirola",
            "Camigliatello Silano",
            "Campigna Santa Sofia",
            "Campitello di Fassa",
            "Campitello Matese",
            "Campo di Giove",
            "Campo Felice",
            "Campo Imperatore",
            "Campo Staffi",
            "Campocatino",
            "CAMPOMULO",
            "Canazei",
            "Canosio",
            "Cappadocia",
            "Capracotta",
            "CAREGGINE",
            "Carezza",
            "Carona",
            "Casa Matti",
            "Caspoggio",
            "Celerina",
            "Ceresole Reale",
            "Cerreto Laghi",
            "Cerro Catedral Bariloche",
            "Cesana Torinese",
            "Chamois",
            "Chamonix",
            "Champoluc",
            "Champorcher",
            "Chatel",
            "CHEGGIO DI ANTRONA",
            "Chiesa Valmalenco",
            "Chiomonte",
            "Cimone",
            "Civago Appeninia",
            "Claviere",
            "Cogne",
            "Col de Joux",
            "Colere",
            "Colfosco",
            "Colle del Lys",
            "Collio",
            "Conserva di Lauria",
            "Copper Mountain",
            "Corno Alle Scale",
            "Corno del Renon",
            "Cortina d\'Ampezzo",
            "Corvara",
            "Corvatsch",
            "Courchevel",
            "Courmayeur",
            "Crans Montana",
            "Crevacol",
            "Crissolo",
            "Croda",
            "Cutigliano",
            "Damuels Mellau",
            "Davos",
            "Diavolezza",
            "Dobbiaco",
            "Dolomiti Superski",
            "Domobianca",
            "El Colorado",
            "Entracque",
            "Eremo",
            "Espace Killy",
            "Espace San Bernardo",
            "Etna",
            "Falcade",
            "Falera",
            "Faloria Cristallo",
            "Falzarego",
            "Febbio",
            "Fiescheralp",
            "Finkenberg",
            "Flims",
            "Folgaria",
            "Folgarida",
            "Fonni Bruncu Spina",
            "Foppolo",
            "Forca Canapine",
            "Forcella Aurine",
            "Formazza",
            "Formigal",
            "Forni di Sopra",
            "Frabosa Soprana",
            "Frassinoro Piandelagotti",
            "Frontignano Ussita",
            "Gambarie Aspromonte",
            "Garessio",
            "Garmisch Partenkirchen",
            "Gaver",
            "Ghiacciaio Presena",
            "Grandvalira",
            "Gressoney Saint Jean",
            "Gressoney",
            "Grossglockner Heiligenblut ",
            "Gstaad",
            "Hintertux",
            "Innsbruck",
            "Ischgl",
            "Jackson Hole",
            "webcam Jasna",
            "Kals",
            "katschberg",
            "Kaunertal",
            "webcam killington",
            "kitzbuhel",
            "Kranjska Gora",
            "Kronplatz",
            "La Bresse Hohneck",
            "La Chapelle d\'Abondance",
            "La Clusaz",
            "Laax",
            "webcam lagazuoi",
            "La Grave",
            "La Molina",
            "La Plagne",
            "La Thuile",
            "La Tzoumaz",
            "La Villa",
            "Laax Flims",
            "Laax Murschetg",
            "Lago Laceno",
            "Lago Santo Parmense",
            "Lai de Curnera",
            "Lake Louise",
            "webcam Latemar Obereggen",
            "Lavazè Passo Lavazè",
            "Lecco",
            "Lenk",
            "Le Praz Courchevel",
            "Les Arcs",
            "Les Avellanes i Santa Linya",
            "Les Carroz",
            "Les Deux Alpes",
            "Les Houches",
            "Les Menuires",
            "Leukerbad",
            "Leysin",
            "webcam Livigno",
            "webcam lovere",
            "Lucerne",
            "webcam luz ardiden",
            "Madesimo",
            "Madonna di Campiglio",
            "Maggiora",
            "Malcesine",
            "Malcesine Monte Baldo",
            "Maniva",
            "Maranza",
            "Marebbe",
            "Marilleva",
            "Marotta",
            "Maso Corto Val Senales",
            "Massif du Sancy",
            "Massimeno",
            "Madesimo Pian di Vota",
            "Meiringen Hasliberg",
            "Méribel",
            "Mittersill",
            "montafon",
            "Monte Amiata",
            "Monte Cimone",
            "webcam monte farno",
            "Montgenè",
            "Mont Sainte Anne",
            "Monti di",
            "Montreux",
            "Morgins",
            "Morillon",
            "Morzine",
            "Mottolino",
            "Mürren",
            "Musso",
            "Nauders",
            "Nendaz",
            "Niederau",
            "Nizza Monferrato",
            "Norcia",
            "Novara di Sicilia",
            "Nufenen Pass",
            "webcam obergurgl",
            "Obereggen",
            "Oberjoch",
            "Obersaxen",
            "Oga S. Colombano",
            "Oga Valfurva",
            "Ollomont",
            "Oropa",
            "Orsiera-Rocciavrè",
            "Orta San Giulio",
            "Ortisei",
            "Ortler Skiarena",
            "Paganella",
            "Passo",
            "Payerne",
            "Passo Dordona",
            "Passo Godi",
            "Passo Lavaze",
            "Passo Pramollo",
            "Passo San Pellegrino",
            "Passo Sella",
            "Passo Stelvio",
            "Passo Tonale",
            "Passo Rolle",
            "Passo San Pellegrino Moena",
            "Passignano",
            "Passo Pordoi",
            "Pejo",
            "Peña Francia",
            "Penia Canazei",
            "Penitentes",
            "Pescasseroli",
            "Pescocostanzo",
            "Pfänder",
            "Piandelagotti",
            "Piancavallo",
            "Piandelagotti Frassinoro",
            "Piau Engaly",
            "Pila",
            "Pilatus",
            "Pinzolo",
            "Planai",
            "Plose",
            "Pocapaglia",
            "Pocol",
            "Poggio Berni",
            "Ponte Di Legno",
            "Pontedilegno Tonale",
            "Porretta Terme",
            "Pragelato",
            "Pra Loup",
            "Pralognan la Vanoise",
            "Prato Nevoso",
            "Praz de Lys Sommand",
            "Praz Sur Arly",
            "Pré Saint Didier",
            "Prémanon Les Rousses",
            "Predazzo",
            "Prés d\'Orvin",
            "Presena",
            "Presolana",
            "Presolana Monte Pora",
            "Primi passi",
            "Prinsotel La Dorada",
            "Provaglio d\'Iseo",
            "Prunetta",
            "Pré-Saint-Didier",
            "Racines",
            "Ramsau am Dachstein",
            "Rauris",
            "Realp",
            "Reberty",
            "Reinswald",
            "Remeteség",
            "webcam risoul",
            "Roccaraso",
            "Roccaraso Pizzalto",
            "Rodeneck",
            "Roen",
            "Rosskopf",
            "Ruffrè Mendola",
            "Rukatunturi",
            "Saalbach",
            "Sallent de Gállego",
            "Salice d\'Ulzio",
            "Salinas de Jaca",
            "Salten",
            "San Bernardino",
            "San Colombano",
            "San Domenico di Varzo",
            "San Martino di Castrozza",
            "San Martino",
            "San Pellegrino Terme",
            "San Sicario",
            "San Simione",
            "San Vigilio di Marebbe",
            "San Vito di Cadore",
            "Santa Caterina Valfurva",
            "Santa Caterina Valfurva Valletta",
            "Santa Cristina Val Gardena",
            "Santa Maria Maggiore",
            "Santa Maria Maddalena",
            "Santa Maria Val Müstair",
            "Santa Sofia",
            "Santa Sofia Predappio",
            "Santa Sofia Predappio Alfero",
            "Sant\'Antonio Mavignola Pinzolo",
            "Santo Stefano d\'Aveto",
            "Sauze d\'Oulx",
            "Savognin",
            "Schilpario",
            "Schnalstal",
            "Scuol",
            "Scuola",
            "Seefeld",
            "Sella Nevea",
            "Selva",
            "Selva di Val Gardena",
            "Selva di Val Gardena Monte Pana",
            "Serra San Bruno",
            "Serre Chevalier",
            "Sestola",
            "Sestrière",
            "Sils",
            "siusi",
            "Siusi Alpe di Siusi",
            "Solden",
            "Sölden",
            "Solitude Mountain Resort",
            "Söll",
            "Sondalo",
            "Sonntag Stein",
            "Sonntag Stein im Montafon",
            "Soraga di Fassa",
            "Sörenberg",
            "Sovramonte",
            "St. Johann",
            "St. Johann in Tirol",
            "St. Kassian",
            "St. Kassian La Villa",
            "St. Moritz",
            "St. Ulrich Gröden",
            "St. Ulrich",
            "St. Ulrich Ortisei",
            "St. Valentin auf der Haide",
            "St. Vigil Enneberg",
            "St. Vigil",
            "St. Vigil Enneberg San Vigilio Marebbe",
            "Stalle Passo Stalle",
            "Stelvio Passo Stelvio",
            "St. Leonhard in Passeier",
            "St. Martin de Belleville",
            "St. Moritz Celerina",
            "St. Ulrich Gröden Ortisei",
            "Strachan",
            "Sulden am Ortler",
            "Sun Peaks Resort",
            "Tandil",
            "Tauplitzalm",
            "Teglio",
            "Telšiai",
            "Terme di Comano",
            "Tesero",
            "Thyon Les Collons",
            "Torgnon",
            "Torgnon Chamois",
            "Torgnon Chamois Antagnod",
            "Torgnon Antagnod",
            "Torino",
            "Torgnon Chamois Valtournenche",
            "Torgnon Valtournenche",
            "Torgnon Valtournenche Breuil-Cervinia",
            "Torgnon Valtournenche Zermatt",
            "Torre Pellice",
            "Toscolano Maderno",
            "Torino Cassino Poce",
            "Tragöss",
            "Tramelan",
            "Tramelan Mont Tendre",
            "Trarego",
            "Trebaseleghe",
            "Tre Cime di Lavaredo",
            "Tre Croci",
            "Tre Croci Misurina",
            "Tre Valli",
            "Tresché Conca",
            "Tresché Conca Gallio",
            "Tresché Conca Lavarone",
            "Treviso",
            "Trient",
            "Tschierv",
            "Tschierv Müstair",
            "Tschierv Val Müstair",
            "Tulfes",
            "Turnau",
            "Turracherhöhe",
            "Tuscania",
            "Uden",
            "Uden Tufarm",
            "Ulfas",
            "Ulfas",
            "Ulrichen",
            "Ulrichen Ulrichon",
            "Ulrichen Obergoms",
            "Unterreichenbach",
            "Utelle",
            "Utelle Chastellaras",
            "Valfrejus",
            "Valgrisenche",
            "Vallecrosia",
            "Vallée",
            "Valmala",
            "Valmeinier",
            "Valmorel",
            "Valseriana",
            "Val di Fassa",
            "Val di Fiemme",
            "Val di Luce",
            "Val di Rabbi"});
            this.dungeonComboBox1.Location = new System.Drawing.Point(528, 27);
            this.dungeonComboBox1.Name = "dungeonComboBox1";
            this.dungeonComboBox1.Size = new System.Drawing.Size(250, 26);
            this.dungeonComboBox1.StartIndex = 0;
            this.dungeonComboBox1.TabIndex = 63;
            this.dungeonComboBox1.SelectedIndexChanged += new System.EventHandler(this.dungeonComboBox1_SelectedIndexChanged);
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Location = new System.Drawing.Point(12, 148);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(400, 400);
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 64;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopePictureBox3
            // 
            this.hopePictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox3.Location = new System.Drawing.Point(904, 148);
            this.hopePictureBox3.Name = "hopePictureBox3";
            this.hopePictureBox3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox3.Size = new System.Drawing.Size(400, 400);
            this.hopePictureBox3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox3.TabIndex = 65;
            this.hopePictureBox3.TabStop = false;
            this.hopePictureBox3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lostCancelButton1
            // 
            this.lostCancelButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.lostCancelButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostCancelButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lostCancelButton1.ForeColor = System.Drawing.Color.White;
            this.lostCancelButton1.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.lostCancelButton1.Image = null;
            this.lostCancelButton1.Location = new System.Drawing.Point(1043, 554);
            this.lostCancelButton1.Name = "lostCancelButton1";
            this.lostCancelButton1.Size = new System.Drawing.Size(167, 40);
            this.lostCancelButton1.TabIndex = 68;
            this.lostCancelButton1.Text = "CERCA";
            this.lostCancelButton1.Click += new System.EventHandler(this.lostCancelButton1_Click);
            // 
            // lostCancelButton2
            // 
            this.lostCancelButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.lostCancelButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostCancelButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lostCancelButton2.ForeColor = System.Drawing.Color.White;
            this.lostCancelButton2.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.lostCancelButton2.Image = null;
            this.lostCancelButton2.Location = new System.Drawing.Point(584, 554);
            this.lostCancelButton2.Name = "lostCancelButton2";
            this.lostCancelButton2.Size = new System.Drawing.Size(167, 40);
            this.lostCancelButton2.TabIndex = 69;
            this.lostCancelButton2.Text = "CERCA";
            this.lostCancelButton2.Click += new System.EventHandler(this.lostCancelButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 47);
            this.label2.TabIndex = 70;
            this.label2.Text = "webcam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 47);
            this.label3.TabIndex = 71;
            this.label3.Text = "piste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(896, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 47);
            this.label4.TabIndex = 72;
            this.label4.Text = "Meteo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 606);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lostCancelButton2);
            this.Controls.Add(this.lostCancelButton1);
            this.Controls.Add(this.hopePictureBox3);
            this.Controls.Add(this.hopePictureBox1);
            this.Controls.Add(this.dungeonComboBox1);
            this.Controls.Add(this.hopePictureBox2);
            this.Controls.Add(this.btncerca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.LostCancelButton btncerca;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox3;
        private ReaLTaiizor.Controls.LostCancelButton lostCancelButton1;
        private ReaLTaiizor.Controls.LostCancelButton lostCancelButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

