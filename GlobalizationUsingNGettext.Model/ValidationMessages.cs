using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalizationUsingNGettext.Model
{
    public static class ValidationMessages
    {
        public const string LOGIN_FAILED = "[[[Bitte überprüfe Deine Anmeldedaten.///this is an extracted comment]]]";
        public const string ACCOUNT_NOT_ACTIVATED = "Dein Konto ist nicht aktiviert. Überprüfe bitte Dein E-Mail Postfach und klicke auf den Aktivierungslink.";
        public const string EMAIL_ALREADY_EXIST = "Diese E-Mail Adresse wurde bereits für eine Registrierung verwendet. Bitte überprüfe Deine Eingaben und gebe eine andere E-Mail Adresse an.";
        public const string EMAIL_FOR_ACCOUNT_ACTIVATION = "Wir haben Dir Deinen Aktivierungslink an Deine E-Mail Adresse geschickt. Um Dein Konto zu aktivieren, klicke auf den Link in der E-Mail.";
        public const string EMAIL_SENDING_FAILED = "Emailversand derzeit nicht möglich. Bitte wende Dich an den Kundenservice!";
        public const string FORM_ERROR = "Ein Fehler ist aufgetreten, versuche es nochmal.";
        public const string FORM_VALIDATION_ERROR = "Es ist ein Fehler aufgetreten. Überprüfe Deine Eingaben und versuche es nochmal.";
        public const string ACTIVATION_SUCCESSED = "Ihr Benutzerkonto wurde freigeschaltet. Sie können die App jetzt ohne Einschränkungen benutzen. Loggen sie sich mit ihrer E-Mail-Adresse und Ihrem Passwort ein";
        public const string ACTIVATION_FAILED = "Die Aktivierung ihres Benutzerkontos war nicht erfolgreich. Loggen sie sich mit ihrer E-Mail-Adresse und Ihrem Passwort ein und lassen sich einen neuen Aktivierungslink zuschicken.";
        public const string VEHICLE_LICENCEPLATE_DOES_EXIST = "Ein Fahrzeug mit diesem Kennzeichen ist bereits vorhanden.";
        public const string SELECT_SERVICE_ERROR = "Bitte wähle mindestens einen Service aus.";
        public const string APPOINTMENT_CANNOT_BE_CREATED = "Termin kann nicht erstellt werden.";
        public const string APPOINTMENT_SELECT_ANOTHER = "Bitte wähle einen anderen Termin.";
        public const string APPOINTMENT_CANNOT_BE_RESERVED = "Termin konnte nicht reserviert werden.";
        public const string ADDRESS_SAVED = "Die Adresse wurde gespeichert.";
        public const string PASSWORD_FORGOT_EMAIL_SENT = "[[[Wir haben Dir unter der von Dir angegebenen E-Mail-Addresse eine E-Mail geschickt. Bitte beachte die Hinweise in dieser E-Mail, um Dein Kundenkonto wieder nutzen zu können.]]]";
        public const string PASSWORD_FORGOT_EMAIL_NOT_EXIST = "Deine eingegebene E-Mail Adresse ist bei uns nicht hinterlegt. Bitte prüfen Deine Eingaben und versuche es erneut!";
        public const string PASSWORD_CANNOT_RESET = "Das Passwort kann nicht zurückgesetzt werden, bitte versuche es nochmal.";
        public const string PASSWORD_RESET_LINK_NOT_VALID = "Der Link ist ungültig, bitte fordere ein neues Passwort an.";
        public const string VEHICLE_LICENCE_PLATE_ALREADY_EXIST = "Ein Fahrzeug mit diesem Kennzeichen ist bereits vorhanden.";
        public const string CUSTOMER_NOT_FOUND = "Benutzer kann nicht gefunden werden.";
        public const string NOTE_THE_REQUIRED_FIELDS = "Bitte die Pflichtfelder beachten.";
        public const string CALENDARLIST_UPDATED = "Kalenderlisten aktualisiert";
        public const string PVMANANGER_NOT_AVAILABLE = "PV:MANAGER nicht erreichbar";


    }
}
