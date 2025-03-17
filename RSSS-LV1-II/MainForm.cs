using System.Runtime.CompilerServices;

namespace RSSS_LV1_II;

public partial class MainForm : Form
{
    int hours;
    int minutes;

    System.Timers.Timer? alarmTimer;
    System.Timers.Timer? timeUntilAlarmLabelUpdateTimer;
    TimeSpan alarmTimeStamp;

    public MainForm()
    {
        InitializeComponent();

        TimeSpan now = DateTime.Now.TimeOfDay;
        this.hours = now.Hours;
        this.minutes = now.Minutes;
        UpdateLabels();
    }

    private void HoursUpButton_Click(object sender, EventArgs e)
    {
        this.hours += 1;
        if (hours > 23)
            hours = 0;
        UpdateLabels();
    }

    private void HoursDownButton_Click(object sender, EventArgs e)
    {
        this.hours -= 1;
        if (hours < 0)
            hours = 23;
        UpdateLabels();
    }

    private void MinutesDownButton_Click(object sender, EventArgs e)
    {
        this.minutes -= 1;
        if (minutes < 0)
            minutes = 59;
        UpdateLabels();
    }

    private void MinutesUpButton_Click(Object sender, EventArgs e)
    {
        this.minutes += 1;
        if (minutes > 59)
            minutes = 0;
        UpdateLabels();
    }

    void UpdateLabels()
    {
        this.HourLabel.Text = (this.hours < 10) ? $"0{this.hours}" : this.hours.ToString();
        this.MinuteLabel.Text = (this.minutes < 10) ? $"0{this.minutes}" : this.minutes.ToString();
    }

    private void SetAlarmButton_Click(object sender, EventArgs e)
    {
        StopTimers();
        this.alarmTimeStamp = new(hours, minutes, 0);
        
        UpdateTimeUntilAlarmLabel(sender, e);
        this.timeUntilAlarmLabelUpdateTimer = new(1000);
        this.timeUntilAlarmLabelUpdateTimer.Elapsed += new System.Timers.ElapsedEventHandler(UpdateTimeUntilAlarmLabel);
        this.timeUntilAlarmLabelUpdateTimer.Start();

        int milisecondsTillAlarm = (int)(CalculateTicksTillAlarm() / TimeSpan.TicksPerMillisecond);
        this.alarmTimer = new(milisecondsTillAlarm);
        this.alarmTimer.Elapsed += new System.Timers.ElapsedEventHandler(BuzzOnAlarmTime);
        this.alarmTimer.Start();
    }

    long CalculateTicksTillAlarm()
    {
        TimeSpan result = alarmTimeStamp - DateTime.Now.TimeOfDay;
        long ticksTillAlarm = result.Ticks;
        if (ticksTillAlarm < 0)
            ticksTillAlarm = TimeSpan.TicksPerDay + ticksTillAlarm;

        return ticksTillAlarm;
    }

    void UpdateTimeUntilAlarmLabel(object? sender, EventArgs e)
    {
        TimeSpan result = new(CalculateTicksTillAlarm());

        string remainingHours = result.Hours < 10 ? $"0{result.Hours}" : result.Hours.ToString();
        string remainingMinutes = result.Minutes < 10 ? $"0{result.Minutes}" : result.Minutes.ToString();
        string remainingSeconds = result.Seconds < 10 ? $"0{result.Seconds}" : result.Seconds.ToString();

        this.AlarmInfoLabel.Text = $"Alarm set for {this.HourLabel.Text}:{this.MinuteLabel.Text}\n(In {remainingHours}:{remainingMinutes}:{remainingSeconds})";
    }

    void StopTimers()
    {
        this.alarmTimer?.Stop();
        this.alarmTimer?.Dispose();
        this.timeUntilAlarmLabelUpdateTimer?.Stop();
        this.timeUntilAlarmLabelUpdateTimer?.Dispose();
    }

    private void BuzzOnAlarmTime(object? sender, EventArgs e)
    {
        StopTimers();
        this.AlarmInfoLabel.Text = $"TIME IS UP!";

        Console.Beep(250, 500);
        Console.Beep(550, 500);
        Console.Beep(950, 500);
        Console.Beep(550, 500);
        Console.Beep(1150, 500);
        Console.Beep(550, 500);
        this.AlarmInfoLabel.Text = "Set a new alarm";
    }
}
