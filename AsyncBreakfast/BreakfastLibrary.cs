using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncBreakfast
{
    public class BreakfastLibrary
    {
        private static string CompleteMisenplace(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s= "Misenplace complete.\r\n";
            return s;
        }

        private static async Task<string> CompleteMisenplaceAsync(int workMilliseconds)  // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Misenplace copmplete.\r\n";
            });

            return s;
        }

        private static string BrewCoffee(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Coffee brewed.\r\n";
            return s;
        }

        private static string PourCoffee(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Coffee poured. Enjoy!\r\n";
            return s;
        }

        private static async Task<string> BrewCoffeeAsync(int workMilliseconds)  // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Coffee brewed.\r\n";
            });
            return s;
        }

        private static async Task<string> PourCoffeeAsync(int workMilliseconds)  // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = ("Coffee poured. Enjoy!\r\n");
            });
            return s;
        }

        private static string HeatFlattop(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Flattop ready to go!\r\n";
            return s;
        }

        private static async Task<string> HeatFlattopAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Flattop ready to go!\r\n";
            });
            return s;
        }

        private static string ToastBread(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Toast is Ready!\r\n";
            return s;
        }

        private static async Task<string> ToastBreadAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s += "Toast is Ready!\r\n";
            });
            return s;
        }

        private static string PutButterAndJamOnToast(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Toast is buttered and jammed!\r\n";
            return s;
        }

        private static async Task<string> PutButterAndJamOnToastAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Toast is buttered and jammed!\r\n";
            });
            return s;
        }

        private static string CookBacon(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Bacon is cooked!\r\n";
            return s;
        }

        private static async Task<string> CookBaconAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Bacon is cooked!\r\n";
            });
            return s;
        }

        private static string CookSausage(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Sausage is cooked!\r\n";
            return s;
        }

        private static async Task<string> CookSausageAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Sausage is cooked!\r\n";
            });
            return s;
        }

        private static string PlateBacon(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Bacon is on the plate!\r\n";
            return s;
        }

        private static async Task<string> PlateBaconAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Bacon is on the plate!\r\n";
            });
            return s;
        }

        private static string PlateSausage(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Sausage is on the plate!\r\n";
            return s;
        }

        private static async Task<string> PlateSausageAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Sausage is on the plate!\r\n";
            });
            return s;
        }

        private static string PlateToast(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Toast is on the plate!\r\n";
            return s;
        }

        private static async Task<string> PlateToastAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait() ;
                s = "Toast is on the plate!\r\n";
            });
            return s;
        }

        private static string CookEggs(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Eggs are cooked to order!\r\n";
            return s;
        }

        private static async Task<string> CookEggsAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Eggs are cooked to order!\r\n";
            });
            return s;
        }

        private static string PlateEggs(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Eggs are plated!\r\n";
            return s;
        }

        private static async Task<string> PlateEggsAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Eggs are plated!\r\n";
            });
            return s;
        }

        private static string PourJuice(int workMilliseconds)
        {
            string s = string.Empty;
            Task.Delay(workMilliseconds).Wait();
            s = "Juice is poured!\r\n";
            return s;
        }

        private static async Task<string> PourJuiceAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            string s = string.Empty;
            await Task.Run(() =>
            {
                Task.Delay(workMilliseconds).Wait();
                s = "Juice is poured!\r\n";
            });
            return s;
        }

        public static async Task MakeBreakfastParallelAsync(Form1 form)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            form.BreakfastProgress.Text = "Starting to prepare Asynchronous Parallel Breakfast.\r\n\r\n";

            //**************************************************************************************
            // Kick off these tasks in parallel
            form.BreakfastProgress.Text += ("Brew coffee and complete misenplace...\r\n");
            List<Task<string>> tasks = new List<Task<string>>
            {
                Task.Run(() => BrewCoffeeAsync(2000)),
                Task.Run(() => CompleteMisenplace(3500))
            };
            // Subsequent tasks depend on the completion of these tasks, so wait for them to finish
            await Task.WhenAll(tasks);
            form.BreakfastProgress.Text += tasks[0].Result;
            form.BreakfastProgress.Text += tasks[1].Result + "\r\n";

            //**************************************************************************************
            // Kick off these tasks in parallel
            form.BreakfastProgress.Text += "Heating up the flattop and toasting the bread...\r\n";
            tasks = new List<Task<string>>
            {
                Task.Run(() => HeatFlattopAsync(2000)),
                Task.Run(() => ToastBreadAsync(3500))
            };
            // Subsequent tasks depend on the completion of these tasks, so wait for them to finish
            await Task.WhenAll(tasks);
            form.BreakfastProgress.Text += tasks[0].Result;
            form.BreakfastProgress.Text += tasks[1].Result + "\r\n";

            //**************************************************************************************
            // Kick of these cooking/preparation tasks in parallel
            form.BreakfastProgress.Text += "Cooking the Bacon and Sausage and putting butter and jam on the toast...\r\n";
            tasks = new List<Task<string>>
            {
                Task.Run(() => PutButterAndJamOnToastAsync(4500)),
                Task.Run(() => CookBaconAsync(4200)),
                Task.Run(() => CookSausageAsync(5200))
            };
            // Subsequent tasks depend on the completion of these, so wait for all of them to finish to continue
            await Task.WhenAll(tasks);
            form.BreakfastProgress.Text += tasks[0].Result;
            form.BreakfastProgress.Text += tasks[1].Result;
            form.BreakfastProgress.Text += tasks[2].Result + "\r\n";

            //*************************************************************************************
            // Kick off these plating tasks in parallel
            form.BreakfastProgress.Text += "Plating the cooked bacon, sausage and toast...\r\n";
            tasks = new List<Task<string>>
            {
                Task.Run(() => PlateBaconAsync(2000)),
                Task.Run(() => PlateSausageAsync(1800)),
                Task.Run(() => PlateToastAsync(2200))
            };
            // Subsequent tasks depend on the completion of all of these.  Wait until they are all done before continuing.
            await Task.WhenAll(tasks);
            form.BreakfastProgress.Text += tasks[0].Result;
            form.BreakfastProgress.Text += tasks[1].Result;
            form.BreakfastProgress.Text += tasks[2].Result + "\r\n";

            //**************************************************************************************
            // Kick off these plating tasks in parallel
            form.BreakfastProgress.Text += "Cooking the eggs to order and pouring the juice...\r\n";
            tasks = new List<Task<string>>
            {
                Task.Run(() => CookEggsAsync(5000)),
                Task.Run(() => PourJuiceAsync(3500))
            };
            // Subsequent tasks depend on the completion of all of these.  Wait until they are all done before continuing.
            await Task.WhenAll(tasks);
            form.BreakfastProgress.Text += tasks[0].Result;
            form.BreakfastProgress.Text += tasks[1].Result + "\r\n";

            //**************************************************************************************
            // Kick off the cooking of the eggs and wait for it to complete
            form.BreakfastProgress.Text += "Plate the eggs...\r\n";
            string s = await Task.Run(() => PlateEggs(3800));
            form.BreakfastProgress.Text += s + "\r\n";

            //**************************************************************************************
            // Finally, Pour the nice, flavorful hot Coffee
            form.BreakfastProgress.Text += "Pour the nice, flavorful, hot coffee...\r\n";
            s = await Task.Run(() => PourCoffee(2000));
            form.BreakfastProgress.Text += s + "\r\n";

            sw.Stop();
            form.BreakfastProgress.Text += $"Asynchronous Parallel Breakfast is served!\r\nIt was prepared in {sw.ElapsedMilliseconds/1000.0} seconds.";
            sw.Reset();

            form.ProcessingComplete(ProcessingTypeEnum.PARALLEL);
        }

        public static void MakeBreakfastSync(Form1 form)
        {
            string s = string.Empty;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            form.BreakfastProgressSync.Text = "Starting to prepare Synchronous Breakfast.\r\n\r\n";

            // Brew Coffee
            form.BreakfastProgressSync.Text += "Brew coffee...\r\n";
            s = BrewCoffee(2000);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Complete Misenplace
            form.BreakfastProgressSync.Text += "Complete Misenplace...\r\n";
            s = CompleteMisenplace(4000);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Heat Flattop
            form.BreakfastProgressSync.Text += "Heating up the flattop...\r\n";
            s = HeatFlattop(2000);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Toast the Bread
            form.BreakfastProgressSync.Text += "Toast the bread...\r\n";
            s = ToastBread(3500);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Cook Bacon
            form.BreakfastProgressSync.Text += "Cook bacon...\r\n";
            s = CookBacon(4500);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Cook Sausage
            form.BreakfastProgressSync.Text += "Cook sausage...\r\n";
            s = CookSausage(4200);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Put butter and jam on the toast
            form.BreakfastProgressSync.Text += "Put butter and jam on the toast...\r\n";
            s = PutButterAndJamOnToast(5200);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Plate Bacon
            form.BreakfastProgressSync.Text += "Bacon plated...\r\n";
            s = PlateBacon(2000);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Plate Sausage
            form.BreakfastProgressSync.Text += "Sausage plated...\r\n";
            s = PlateSausage(1800);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Plate the toast
            form.BreakfastProgressSync.Text += "Toast plated...\r\n";
            s = PlateToast(2200);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Cook the eggs
            form.BreakfastProgressSync.Text += "Eggs cooked to order...\r\n";
            s = CookEggs(5000);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Pour the juice
            form.BreakfastProgressSync.Text += "Juice poured...\r\n";
            s = PourJuice(3500);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Plate the eggs
            form.BreakfastProgressSync.Text += "Plate the eggs...\r\n";
            s = PlateEggs(3800);
            form.BreakfastProgressSync.Text += s + "\r\n";

            // Pour the coffee
            form.BreakfastProgressSync.Text += "Pour the nice, flavorful, hot coffee...\r\n";
            s = PourCoffee(2000);
            form.BreakfastProgressSync.Text += s + "\r\n";

            sw.Stop();
            form.BreakfastProgressSync.Text += $"Synchronous Breakfast is served!\r\nIt was prepared in {sw.ElapsedMilliseconds / 1000.0} seconds.";
            sw.Reset();

            form.ProcessingComplete(ProcessingTypeEnum.SYNC);
        }

        public static async Task MakeBreakfastAsync(Form1 form)
        {
            string s = string.Empty;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            form.BreakfastProgressAsync.Text = "Starting to prepare Asynchronous Breakfast.\r\n\r\n";

            // Brew Coffee
            form.BreakfastProgressAsync.Text += "Brew coffee...\r\n";
            s = await Task.Run(() => BrewCoffeeAsync(2000));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Complete Misenplace
            form.BreakfastProgressAsync.Text += "Complete Misenplace...\r\n";
            s = await Task.Run(() => CompleteMisenplaceAsync(4000));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Heat Flattop
            form.BreakfastProgressAsync.Text += "Heating up the flattop...\r\n";
            s = await Task.Run(() => HeatFlattopAsync(2000));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Toast the Bread
            form.BreakfastProgressAsync.Text += "Toast the bread...\r\n";
            s = await Task.Run(() => ToastBreadAsync(3500));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Cook Bacon
            form.BreakfastProgressAsync.Text += "Cook bacon...\r\n";
            s = await Task.Run(() => CookBaconAsync(4500));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Cook Sausage
            form.BreakfastProgressAsync.Text += "Cook sausage...\r\n";
            s = await Task.Run(() => CookSausageAsync(4200));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Put butter and jam on the toast
            form.BreakfastProgressAsync.Text += "Put butter and jam on the toast...\r\n";
            s = await Task.Run(() => PutButterAndJamOnToastAsync(5200));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Plate Bacon
            form.BreakfastProgressAsync.Text += "Plate the Bacon...\r\n";
            s = await Task.Run(() => PlateBaconAsync(2000));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Plate Sausage
            form.BreakfastProgressAsync.Text += "Plate the Sausage...\r\n";
            s = await Task.Run(() => PlateSausageAsync(1800));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Plate the toast
            form.BreakfastProgressAsync.Text += "Plate the toast...\r\n";
            s = await Task.Run(() => PlateToastAsync(2200));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Cook the eggs
            form.BreakfastProgressAsync.Text += "Cook Eggs to order...\r\n";
            s = await Task.Run(() => CookEggsAsync(5000));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Pour the juice
            form.BreakfastProgressAsync.Text += "Pour the Juice...\r\n";
            s = await Task.Run(() => PourJuiceAsync(3500));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Plate the eggs
            form.BreakfastProgressAsync.Text += "Plate the eggs...\r\n";
            s = await Task.Run(() => PlateEggsAsync(3800));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            // Pour the coffee
            form.BreakfastProgressAsync.Text += "Pour the nice, flavorful, hot coffee...\r\n";
            s = await Task.Run(() => PourCoffeeAsync(2000));
            form.BreakfastProgressAsync.Text += s + "\r\n";

            sw.Stop();
            form.BreakfastProgressAsync.Text += $"Asynchronous Breakfast is served!\r\nIt was prepared in {sw.ElapsedMilliseconds / 1000.0} seconds.";
            sw.Reset();

            form.ProcessingComplete(ProcessingTypeEnum.ASYNC);
        }

        /*
        private static void WriteTaskStatus(string taskName, TaskStatus status)
        {
            switch (status)
            {
                case TaskStatus.Canceled:
                    Console.WriteLine($"{taskName} was canceled.");
                    break;
                case TaskStatus.Faulted:
                    Console.WriteLine($"{taskName} faulted.");
                    break;
                case TaskStatus.RanToCompletion:
                    Console.WriteLine($"{taskName} ran to completion.");
                    break;
                case TaskStatus.Running:
                    Console.WriteLine($"{taskName} is still running.  How did I get here?");
                    break;
                case TaskStatus.WaitingForChildrenToComplete:
                    Console.WriteLine($"{taskName} is waiting for children to complete.  How did I get here?");
                    break;
                case TaskStatus.WaitingForActivation:
                    Console.WriteLine($"{taskName} is waiting for activation.  How did I get here?");
                    break;
                case TaskStatus.WaitingToRun:
                    Console.WriteLine($"{taskName} is waiting to run.  How did I get here?");
                    break;
                default:
                    Console.WriteLine("UNKNOWN Task Status received.");
                    break;
            }

            Console.WriteLine("");
        }
        */
    }
}
