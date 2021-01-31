namespace CodeWarsKatas.katas._5_kyu
{
    
// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
// HH = hours, padded to 2 digits, range: 00 - 99
// MM = minutes, padded to 2 digits, range: 00 - 59
// SS = seconds, padded to 2 digits, range: 00 - 59
// The maximum time never exceeds 359999 (99:59:59)
    static class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            var convertedHours = (seconds / 3600);
            var convertedMinutes =   (seconds - (convertedHours * 3600)) / 60 ;
            var convertedSeconds = seconds - (convertedHours * 3600) -  (convertedMinutes * 60);

            return $"{(convertedHours.ToString("00"))}:{(convertedMinutes.ToString("00"))}:{(convertedSeconds.ToString("00"))}";
        }
    }
}

