using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Primes_Async
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            listBoxPrimes.Items.Clear();

            int start = 2;
            int end = int.MaxValue;

            if (int.TryParse(txtLower.Text, out int lower))
                start = Math.Max(2, lower);

            if (int.TryParse(txtUpper.Text, out int upper))
                end = upper;

            cts = new CancellationTokenSource();
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            try
            {
                await GeneratePrimesAsync(start, end, cts.Token);
            }
            catch (OperationCanceledException)
            {
            }
            finally
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }

        private async Task GeneratePrimesAsync(int start, int end, CancellationToken token)
        {
            for (int i = start; i <= end; i++)
            {
                token.ThrowIfCancellationRequested();

                if (IsPrime(i))
                {
                    Invoke(new Action(() =>
                    {
                        listBoxPrimes.Items.Add(i);
                    }));
                }
                if (i % 500 == 0)
                    await Task.Delay(1, token);
            }
        }

        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }

        private void listBoxPrimes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}