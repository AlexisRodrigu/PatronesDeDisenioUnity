using Object = UnityEngine.Object;

public class MutantsFactory 
    {
        private readonly MutantConfiguration _mutantConfiguration;
        
        //Creamos al mutante
        public MutantsFactory(MutantConfiguration mutantConfiguration)
        {
            _mutantConfiguration = mutantConfiguration;
        }

        public Mutants Create(string id)
        {
            var mutant = _mutantConfiguration.GetMutantPrefab(id);

            return Object.Instantiate(mutant);
        }
    }
