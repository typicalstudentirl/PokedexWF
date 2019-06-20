﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;

namespace WFInterviewPractise.Models
{
    public class PokemonEntity
    {
        public class Color
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class EggGroup
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class EvolutionChain
        {
            public string url { get; set; }
        }

        public class Language
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Version
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class FlavorTextEntry
        {
            public string flavor_text { get; set; }
            public Language language { get; set; }
            public Version version { get; set; }
        }

        public class Language2
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Genera
        {
            public string genus { get; set; }
            public Language2 language { get; set; }
        }

        public class Generation
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class GrowthRate
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Habitat
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Language3
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Name
        {
            public Language3 language { get; set; }
            public string name { get; set; }
        }

        public class Area
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class PalParkEncounter
        {
            public Area area { get; set; }
            public int base_score { get; set; }
            public int rate { get; set; }
        }

        public class Pokedex
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class PokedexNumber
        {
            public int entry_number { get; set; }
            public Pokedex pokedex { get; set; }
        }

        public class Shape
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Pokemon
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Variety
        {
            public bool is_default { get; set; }
            public Pokemon pokemon { get; set; }
        }

            public int base_happiness { get; set; }
            public int capture_rate { get; set; }
            public Color color { get; set; }
            public List<EggGroup> egg_groups { get; set; }
            public EvolutionChain evolution_chain { get; set; }
            public object evolves_from_species { get; set; }
            public List<FlavorTextEntry> flavor_text_entries { get; set; }
            public List<object> form_descriptions { get; set; }
            public bool forms_switchable { get; set; }
            public int gender_rate { get; set; }
            public List<Genera> genera { get; set; }
            public Generation generation { get; set; }
            public GrowthRate growth_rate { get; set; }
            public Habitat habitat { get; set; }
            public bool has_gender_differences { get; set; }
            public int hatch_counter { get; set; }
            public int id { get; set; }
            public bool is_baby { get; set; }
            public string name { get; set; }
            public List<Name> names { get; set; }
            public int order { get; set; }
            public List<PalParkEncounter> pal_park_encounters { get; set; }
            public List<PokedexNumber> pokedex_numbers { get; set; }
            public Shape shape { get; set; }
            public List<Variety> varieties { get; set; }
            // Http Response properties
            public string errorMessage { get; set; }
            public string result { get; set; }
            public string resultString { get; set; }
            public string reasonPhrase { get; set; }
            public HttpResponseHeaders headers { get; set; }
            public HttpStatusCode code { get; set; }
    }
}


//    public int base_happiness { get; set; }

//    public int capture_rate { get; set; }

//    public Color color { get; set; }

//    public Egg_Groups egg_groups { get; set; }

//    public Evolution_Chain evolution_chain { get; set; }

//    public string evoles_from_species
//}

//public class Color
//{
//    public string name { get; set; }

//    public string url { get; set; }
//}

//public class Egg_Groups
//{
//    public string name { get; set; }

//    public string url { get; set; }
//}

//public class Evolution_Chain
//{
//    public string url { get; set; }
//}


