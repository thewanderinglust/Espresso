using UnityEngine;

namespace Espresso.GamelogicUtilities
{
    public class Timer
    {
        /// <summary>
        /// The time that this timer is counting up towards each frame.
        /// </summary>
        private float m_timerTarget;

        /// <summary>
        /// The current elapsed time that the timer has been ticking for.
        /// </summary>
        private float m_elapsedTime;

        /// <summary>
        /// Returns true if the total elapsed time for this timer is greater than or equal to the target time.
        /// </summary>
        public bool IsTimerComplete {get { return m_elapsedTime >= m_timerTarget; } }

        /// <summary>
        /// Returns a float representing the percentage of the time passed over the target time.
        /// </summary>
        public float ElapsedPercentage {get { return m_elapsedTime / m_timerTarget; } }

        /// <summary>
        /// Returns a float representing the remaining time to the target time as a percentage of the target time;
        /// </summary>
        public float RemainingPercentage { get { return (m_timerTarget - m_elapsedTime) / m_timerTarget; } }

        /// <summary>
        /// Construct a new timer with a given target time to count up towards.
        /// </summary>
        /// <param name="a_timeToTrackInSeconds">The time that the timer is counting up to each frame.</param>
        public Timer(float a_timeToTrackInSeconds)
        {
            m_elapsedTime = 0;
            m_timerTarget = a_timeToTrackInSeconds;
        }

        /// <summary>
        /// Adds deltatime to the timer's elapsed time. This function must be called or the timer will not count up.
        /// </summary>
        public void Tick()
        {
            m_elapsedTime += Time.deltaTime;
        }

        /// <summary>
        /// Clears the current elapsed time.
        /// </summary>
        public void ResetTimer()
        {
            m_elapsedTime = 0;
        }

        /// <summary>
        /// Assigns this timer a new target time. Optionally resets elapsed time.
        /// </summary>
        /// <param name="a_newTargetTime">The new target time for this timer.</param>
        /// <param name="a_resetElapsedTime">Also sets elapsed time to 0. False by default.</param>
        public void SetNewTargetTime(float a_newTargetTime, bool a_resetElapsedTime = false)
        {
            if (a_resetElapsedTime)
            {
                ResetTimer();
            }

            m_timerTarget = a_newTargetTime;
        }
    }
}