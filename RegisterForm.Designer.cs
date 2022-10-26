namespace GMS
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.city = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.newUsernameLbl = new System.Windows.Forms.Label();
            this.signupTitle = new System.Windows.Forms.Label();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.loginSuggestion = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Button();
            this.termsOfServiceLink = new System.Windows.Forms.LinkLabel();
            this.readTermsOfService = new System.Windows.Forms.Label();
            this.agreement = new System.Windows.Forms.CheckBox();
            this.cityLbl = new System.Windows.Forms.Label();
            this.countryLbl = new System.Windows.Forms.Label();
            this.birthdayLbl = new System.Windows.Forms.Label();
            this.prefix = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.confirmPassLbl = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.newPassLbl = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.lastnameLbl = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.firstnameLbl = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.city);
            this.LeftPanel.Controls.Add(this.country);
            this.LeftPanel.Controls.Add(this.Birthday);
            this.LeftPanel.Controls.Add(this.newUsername);
            this.LeftPanel.Controls.Add(this.newUsernameLbl);
            this.LeftPanel.Controls.Add(this.signupTitle);
            this.LeftPanel.Controls.Add(this.loginLink);
            this.LeftPanel.Controls.Add(this.loginSuggestion);
            this.LeftPanel.Controls.Add(this.signupBtn);
            this.LeftPanel.Controls.Add(this.termsOfServiceLink);
            this.LeftPanel.Controls.Add(this.readTermsOfService);
            this.LeftPanel.Controls.Add(this.agreement);
            this.LeftPanel.Controls.Add(this.cityLbl);
            this.LeftPanel.Controls.Add(this.countryLbl);
            this.LeftPanel.Controls.Add(this.birthdayLbl);
            this.LeftPanel.Controls.Add(this.prefix);
            this.LeftPanel.Controls.Add(this.phone);
            this.LeftPanel.Controls.Add(this.phoneLbl);
            this.LeftPanel.Controls.Add(this.confirmPass);
            this.LeftPanel.Controls.Add(this.confirmPassLbl);
            this.LeftPanel.Controls.Add(this.newPass);
            this.LeftPanel.Controls.Add(this.newPassLbl);
            this.LeftPanel.Controls.Add(this.email);
            this.LeftPanel.Controls.Add(this.emailLbl);
            this.LeftPanel.Controls.Add(this.lastname);
            this.LeftPanel.Controls.Add(this.lastnameLbl);
            this.LeftPanel.Controls.Add(this.firstname);
            this.LeftPanel.Controls.Add(this.firstnameLbl);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(1100, 672);
            this.LeftPanel.TabIndex = 1;
            // 
            // city
            // 
            this.city.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.city.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.FormattingEnabled = true;
            this.city.Items.AddRange(new object[] {
            "Abu Dhabi",
            "Abuja",
            "Accra",
            "Addis Ababa",
            "Algiers",
            "Amman",
            "Amsterdam[13]",
            "Andorra la Vella",
            "Ankara",
            "Antananarivo",
            "Apia",
            "Ashgabat",
            "Asmara",
            "Asuncion",
            "Athens",
            "Baghdad",
            "Baku",
            "Bamako",
            "Bandar Seri Begawan",
            "Bangkok",
            "Bangui",
            "Banjul",
            "Basseterre",
            "Beijing",
            "Beirut",
            "Belfast",
            "Belgrade",
            "Belmopan",
            "Berlin",
            "Bern",
            "Bishkek",
            "Bissau",
            "Bogota",
            "Brasilia",
            "Bratislava",
            "Brazzaville",
            "Bridgetown",
            "Brussels",
            "Bucharest",
            "Budapest",
            "Buenos Aires",
            "Cairo",
            "Canberra",
            "Caracas",
            "Cardiff",
            "Castries",
            "Chisinau",
            "Colombo[18]",
            "Conakry",
            "Copenhagen",
            "Dakar",
            "Damascus",
            "Dhaka",
            "Dili",
            "Djibouti",
            "Dodoma[20]",
            "Doha",
            "Dublin",
            "Dushanbe",
            "Edinburgh",
            "Freetown",
            "Funafuti[21]",
            "Gaborone",
            "Georgetown",
            "Gitega[3]",
            "Guatemala City",
            "Hanoi",
            "Harare",
            "Havana",
            "Helsinki",
            "Honiara",
            "Islamabad",
            "Jakarta",
            "Jerusalem (very limited international recognition)[9]",
            "Juba",
            "Kabul",
            "Kampala",
            "Kathmandu",
            "Khartoum",
            "Kiev",
            "Kigali",
            "Kingston",
            "Kingstown",
            "Kinshasa",
            "Kuala Lumpur[11]",
            "Kuwait City",
            "La Paz (administrative), Sucre (official)[2]",
            "Libreville",
            "Lilongwe",
            "Lima",
            "Lisbon",
            "Ljubljana",
            "Lome",
            "London",
            "London",
            "Luanda",
            "Lusaka",
            "Luxembourg",
            "Madrid",
            "Majuro",
            "Malabo",
            "Male",
            "Managua",
            "Manama",
            "Manila",
            "Maputo",
            "Maseru",
            "Mbabana[8]",
            "Melekeok",
            "Mexico City",
            "Minsk",
            "Mogadishu",
            "Monaco",
            "Monrovia",
            "Montevideo",
            "Moroni",
            "Moscow",
            "Muscat",
            "N\'Djamena",
            "Nairobi",
            "Nassau",
            "Nay Pyi Taw[12]",
            "New Delhi",
            "Niamey",
            "Nicosia",
            "No official capital",
            "Nouakchott",
            "Nuku\'alofa",
            "Nur-Sultan[10]",
            "Oslo",
            "Ottawa",
            "Ouagadougou",
            "Palikir",
            "Panama City",
            "Paramaribo",
            "Paris",
            "Phnom Penh",
            "Podgorica",
            "Port au Prince",
            "Port Louis",
            "Port Moresby",
            "Port of Spain",
            "Port Vila",
            "Porto Novo[1]",
            "Prague",
            "Praia",
            "Pretoria, Bloemfontein, Cape Town[17]",
            "Pristina",
            "Pyongyang",
            "Quito",
            "Rabat",
            "Reykjavik",
            "Riga",
            "Riyadh",
            "Rome",
            "Roseau",
            "Saint George\'s",
            "Saint John\'s",
            "San Jose",
            "San Marino",
            "San Salvador",
            "Sana\'a[23]",
            "Santiago",
            "Santo Domingo",
            "Sao Tome",
            "Sarajevo",
            "Seoul",
            "Singapore",
            "Skopje",
            "Sofia",
            "Stockholm",
            "Suva",
            "Taipei",
            "Tallinn",
            "Tarawa Atoll",
            "Tashkent",
            "Tbilisi",
            "Tegucigalpa",
            "Tehran",
            "Thimphu",
            "Tirana (Tirane)",
            "Tokyo",
            "Tripoli",
            "Tunis",
            "Ulaanbaatar",
            "Vaduz",
            "Valletta",
            "Vatican City",
            "Victoria",
            "Vienna",
            "Vientiane",
            "Vilnius",
            "Warsaw",
            "Washington D.C.",
            "Wellington",
            "Windhoek",
            "Yamoussoukro[4]",
            "Yaounde",
            "Yerevan",
            "Zagreb"});
            this.city.Location = new System.Drawing.Point(768, 148);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(148, 32);
            this.city.TabIndex = 65;
            this.city.Text = "City";
            // 
            // country
            // 
            this.country.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.country.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "",
            "Fiji",
            "Finland",
            "France",
            "",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "",
            "Haiti",
            "Honduras",
            "Hungary",
            "",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "",
            "Jamaica",
            "Japan",
            "Jordan",
            "",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "",
            "Oman",
            "",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "",
            "Qatar",
            "",
            "Romania",
            "Russia",
            "Rwanda",
            "",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sudan, South",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "",
            "Yemen",
            "",
            "Zambia",
            "Zimbabwe"});
            this.country.Location = new System.Drawing.Point(563, 151);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(148, 32);
            this.country.TabIndex = 64;
            this.country.Text = "Country";
            // 
            // Birthday
            // 
            this.Birthday.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Birthday.Location = new System.Drawing.Point(683, 240);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(200, 22);
            this.Birthday.TabIndex = 63;
            // 
            // newUsername
            // 
            this.newUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newUsername.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsername.Location = new System.Drawing.Point(302, 265);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(148, 26);
            this.newUsername.TabIndex = 62;
            // 
            // newUsernameLbl
            // 
            this.newUsernameLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newUsernameLbl.AutoSize = true;
            this.newUsernameLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsernameLbl.Location = new System.Drawing.Point(298, 235);
            this.newUsernameLbl.Name = "newUsernameLbl";
            this.newUsernameLbl.Size = new System.Drawing.Size(117, 27);
            this.newUsernameLbl.TabIndex = 61;
            this.newUsernameLbl.Text = "Username";
            // 
            // signupTitle
            // 
            this.signupTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.signupTitle.AutoSize = true;
            this.signupTitle.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupTitle.Location = new System.Drawing.Point(86, 63);
            this.signupTitle.Name = "signupTitle";
            this.signupTitle.Size = new System.Drawing.Size(198, 32);
            this.signupTitle.TabIndex = 60;
            this.signupTitle.Text = "Sign Up to GMS";
            // 
            // loginLink
            // 
            this.loginLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginLink.AutoSize = true;
            this.loginLink.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLink.Location = new System.Drawing.Point(559, 506);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(63, 24);
            this.loginLink.TabIndex = 59;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Log In";
            // 
            // loginSuggestion
            // 
            this.loginSuggestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginSuggestion.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSuggestion.Location = new System.Drawing.Point(559, 479);
            this.loginSuggestion.Name = "loginSuggestion";
            this.loginSuggestion.Size = new System.Drawing.Size(460, 59);
            this.loginSuggestion.TabIndex = 58;
            this.loginSuggestion.Text = "If you already have an account, please ";
            // 
            // signupBtn
            // 
            this.signupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.signupBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signupBtn.Location = new System.Drawing.Point(563, 428);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(179, 36);
            this.signupBtn.TabIndex = 57;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // termsOfServiceLink
            // 
            this.termsOfServiceLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.termsOfServiceLink.AutoSize = true;
            this.termsOfServiceLink.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsOfServiceLink.Location = new System.Drawing.Point(621, 310);
            this.termsOfServiceLink.Name = "termsOfServiceLink";
            this.termsOfServiceLink.Size = new System.Drawing.Size(148, 24);
            this.termsOfServiceLink.TabIndex = 56;
            this.termsOfServiceLink.TabStop = true;
            this.termsOfServiceLink.Text = "Terms of Service";
            // 
            // readTermsOfService
            // 
            this.readTermsOfService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.readTermsOfService.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readTermsOfService.Location = new System.Drawing.Point(559, 286);
            this.readTermsOfService.Name = "readTermsOfService";
            this.readTermsOfService.Size = new System.Drawing.Size(460, 59);
            this.readTermsOfService.TabIndex = 55;
            this.readTermsOfService.Text = "To create a GMS account, you’ll need to agree \r\nto the ";
            // 
            // agreement
            // 
            this.agreement.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.agreement.AutoSize = true;
            this.agreement.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreement.Location = new System.Drawing.Point(563, 369);
            this.agreement.Name = "agreement";
            this.agreement.Size = new System.Drawing.Size(308, 28);
            this.agreement.TabIndex = 54;
            this.agreement.Text = "I Agree with the Terms of Service";
            this.agreement.UseVisualStyleBackColor = true;
            // 
            // cityLbl
            // 
            this.cityLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLbl.Location = new System.Drawing.Point(763, 121);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(50, 27);
            this.cityLbl.TabIndex = 53;
            this.cityLbl.Text = "City";
            // 
            // countryLbl
            // 
            this.countryLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.countryLbl.AutoSize = true;
            this.countryLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLbl.Location = new System.Drawing.Point(558, 121);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.Size = new System.Drawing.Size(93, 27);
            this.countryLbl.TabIndex = 52;
            this.countryLbl.Text = "Country";
            // 
            // birthdayLbl
            // 
            this.birthdayLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.birthdayLbl.AutoSize = true;
            this.birthdayLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLbl.Location = new System.Drawing.Point(558, 236);
            this.birthdayLbl.Name = "birthdayLbl";
            this.birthdayLbl.Size = new System.Drawing.Size(99, 27);
            this.birthdayLbl.TabIndex = 49;
            this.birthdayLbl.Text = "Birthday";
            // 
            // prefix
            // 
            this.prefix.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prefix.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefix.Location = new System.Drawing.Point(92, 458);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(80, 26);
            this.prefix.TabIndex = 48;
            this.prefix.Text = "+";
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phone.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(178, 458);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(267, 26);
            this.phone.TabIndex = 47;
            // 
            // phoneLbl
            // 
            this.phoneLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(85, 428);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(166, 27);
            this.phoneLbl.TabIndex = 46;
            this.phoneLbl.Text = "Phone number";
            // 
            // confirmPass
            // 
            this.confirmPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmPass.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.Location = new System.Drawing.Point(303, 361);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.PasswordChar = '*';
            this.confirmPass.Size = new System.Drawing.Size(148, 26);
            this.confirmPass.TabIndex = 45;
            // 
            // confirmPassLbl
            // 
            this.confirmPassLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmPassLbl.AutoSize = true;
            this.confirmPassLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassLbl.Location = new System.Drawing.Point(299, 331);
            this.confirmPassLbl.Name = "confirmPassLbl";
            this.confirmPassLbl.Size = new System.Drawing.Size(94, 27);
            this.confirmPassLbl.TabIndex = 44;
            this.confirmPassLbl.Text = "Confirm";
            // 
            // newPass
            // 
            this.newPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newPass.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.Location = new System.Drawing.Point(90, 361);
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '*';
            this.newPass.Size = new System.Drawing.Size(148, 26);
            this.newPass.TabIndex = 43;
            // 
            // newPassLbl
            // 
            this.newPassLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newPassLbl.AutoSize = true;
            this.newPassLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLbl.Location = new System.Drawing.Point(85, 331);
            this.newPassLbl.Name = "newPassLbl";
            this.newPassLbl.Size = new System.Drawing.Size(111, 27);
            this.newPassLbl.TabIndex = 42;
            this.newPassLbl.Text = "Password";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.email.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(90, 265);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(202, 26);
            this.email.TabIndex = 41;
            // 
            // emailLbl
            // 
            this.emailLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(85, 235);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(68, 27);
            this.emailLbl.TabIndex = 40;
            this.emailLbl.Text = "Email";
            // 
            // lastname
            // 
            this.lastname.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lastname.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(303, 151);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(148, 26);
            this.lastname.TabIndex = 39;
            // 
            // lastnameLbl
            // 
            this.lastnameLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lastnameLbl.AutoSize = true;
            this.lastnameLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLbl.Location = new System.Drawing.Point(299, 121);
            this.lastnameLbl.Name = "lastnameLbl";
            this.lastnameLbl.Size = new System.Drawing.Size(113, 27);
            this.lastnameLbl.TabIndex = 38;
            this.lastnameLbl.Text = "Lastname";
            // 
            // firstname
            // 
            this.firstname.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.firstname.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(90, 151);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(148, 26);
            this.firstname.TabIndex = 37;
            // 
            // firstnameLbl
            // 
            this.firstnameLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.firstnameLbl.AutoSize = true;
            this.firstnameLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLbl.Location = new System.Drawing.Point(85, 121);
            this.firstnameLbl.Name = "firstnameLbl";
            this.firstnameLbl.Size = new System.Drawing.Size(115, 27);
            this.firstnameLbl.TabIndex = 36;
            this.firstnameLbl.Text = "Firstname";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.LeftPanel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.Label newUsernameLbl;
        private System.Windows.Forms.Label signupTitle;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Label loginSuggestion;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.LinkLabel termsOfServiceLink;
        private System.Windows.Forms.Label readTermsOfService;
        private System.Windows.Forms.CheckBox agreement;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label countryLbl;
        private System.Windows.Forms.Label birthdayLbl;
        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label confirmPassLbl;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label newPassLbl;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label lastnameLbl;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label firstnameLbl;
    }
}