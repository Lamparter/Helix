using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using Helix.Helpers.NumericalMethods;
using Helix.Helpers.Statistics;
using Helix;

namespace Genome
{
    class Program
    {
        static int Main(string[] args)
        {
            // Create root command with description
            var rootCommand = new RootCommand("Genome CLI for the Helix library")
            {
                CreateIntegrateCommand(),
                CreateDifferentiateCommand(),
                CreateAddAnimalCommand(),
                CreateCalculateMeanCommand()
            };

            // Execute the command
            return rootCommand.InvokeAsync(args).Result;
        }

        // Command to integrate a function
        static Command CreateIntegrateCommand()
        {
            var command = new Command("math-integrate", "Integrate a mathematical function")
            {
                new Argument<double>("start", description: "Integration start point"),
                new Argument<double>("end", description: "Integration end point"),
                new Option<int>("--steps", () => 100, "Number of steps for integration")
            };

            command.Handler = CommandHandler.Create<double, double, int>((start, end, steps) =>
            {
                Func<double, double> function = Math.Sin;  // Example function: f(x) = sin(x)
                double result = Calculus.Integrate(function, start, end, steps);
                Console.WriteLine($"Integration result: {result}");
            });

            return command;
        }

        // Command to differentiate a function
        static Command CreateDifferentiateCommand()
        {
            var command = new Command("math-differentiate", "Differentiate a mathematical function")
            {
                new Argument<double>("point", description: "Point of differentiation")
            };

            command.Handler = CommandHandler.Create<double>((point) =>
            {
                Func<double, double> function = Math.Sin;  // Example function: f(x) = sin(x)
                double result = Calculus.Differentiate(function, point);
                Console.WriteLine($"Differentiation result at {point}: {result}");
            });

            return command;
        }

        // Command to add an animal
        static Command CreateAddAnimalCommand()
        {
            var command = new Command("linnaeus", "Add an animal to the database")
            {
                new Argument<string>("commonName", "The English name of the animal"),
                new Argument<string>("universalName", "The latin name for an animal"),
                new Argument<string>("life", "The life class of the animal"),
                new Argument<string>("domain", "The domain class of the animal"),
                new Argument<string>("kingdom", "The kingdom class of the animal"),
                new Argument<string>("phylum", "The phylum class of the animal"),
                new Argument<string>("class", "The class classification of the animal"),
                new Argument<string>("order", "The order class of the animal"),
                new Argument<string>("family", "The family class of the animal"),
                new Argument<string>("genus", "The genus class of the animal"),
                new Argument<string>("species", "The species class of the animal"),
                new Argument<string>("habitat", "The habitat of the animal"),
                new Argument<string>("conservationStatus", "The conservation status of the animal"),
                new Argument<string>("description", "A description of the animal")
            };

            command.Handler = CommandHandler.Create<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((commonName, universalName, life, domain, kingdom, phylum, classClassification, order, family, genus, species, habitat, conservationStatus, description) =>
            {
                var animal = new Linnaeus(commonName, universalName, life, domain, kingdom, phylum, classClassification, order, family, genus, species, habitat, conservationStatus, description);
                var database = new Linnaeus.AnimalDatabase();
                database.AddAnimal(animal);
            });

            return command;
        }

        // Command to calculate mean
        static Command CreateCalculateMeanCommand()
        {
            var command = new Command("math-mean", "Calculate the mean of a list of numbers")
            {
                new Argument<List<double>>("data", "A list of numbers")
            };

            command.Handler = CommandHandler.Create<List<double>>((data) =>
            {
                double mean = StatisticalAnalysis.CalculateMean(data);
                Console.WriteLine($"Mean of the data: {mean}");
            });

            return command;
        }
    }
}