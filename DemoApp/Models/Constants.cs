using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class Constants
    {
        public enum ClassSelectedEnum
        {
            English = 1,
            Math = 2,
            Music = 3,
            Science = 4
        }

        public const string ExampleJson = @"
[
    {
        'id': '5f5e67e527acc3d1fc2b7229',
        'name': 'Faulkner Burke',
        'age': 18,
        'class': 'Math',
        'grade': 'A'
    },
    {
        'id': '5f5e67e506780d5bc0e3d733',
        'name': 'Hines Lee',
        'age': 15,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5e5df74ca0542d08a',
        'name': 'Webb Sanders',
        'age': 12,
        'class': 'Science',
        'grade': 'D'
    },
    {
        'id': '5f5e67e577e208ffa42e2af3',
        'name': 'Parrish Lindsey',
        'age': 13,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5cd858b08a5406cbe',
        'name': 'Nguyen Harrington',
        'age': 12,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5158e1e1e66b03014',
        'name': 'Mabel Mayer',
        'age': 16,
        'class': 'Math',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5b604b6bd066305c0',
        'name': 'Joanna Saunders',
        'age': 13,
        'class': 'English',
        'grade': 'D'
    },
    {
        'id': '5f5e67e5fbbe8ddf31c5b94e',
        'name': 'Sallie Gardner',
        'age': 16,
        'class': 'Science',
        'grade': 'D'
    },
    {
        'id': '5f5e67e5259239a18acd6178',
        'name': 'Bruce Soto',
        'age': 17,
        'class': 'Math',
        'grade': 'D'
    },
    {
        'id': '5f5e67e54cb6dbfe1445bf06',
        'name': 'Rosetta Conner',
        'age': 18,
        'class': 'Science',
        'grade': 'C'
    },
    {
        'id': '5f5e67e58f8ca7c6f571af04',
        'name': 'Jeanette Fletcher',
        'age': 17,
        'class': 'Math',
        'grade': 'D'
    },
    {
        'id': '5f5e67e51ce3dd8e179aac64',
        'name': 'Kathy Potter',
        'age': 16,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5854d182994f4dfa6',
        'name': 'Susan Duke',
        'age': 12,
        'class': 'Music',
        'grade': 'D'
    },
    {
        'id': '5f5e67e57983fe59c29c4d1d',
        'name': 'Lena Gibbs',
        'age': 17,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e531873f5939a70539',
        'name': 'Rosa Bray',
        'age': 14,
        'class': 'English',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5e60c32c4839602eb',
        'name': 'Shanna Parks',
        'age': 17,
        'class': 'English',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5fb4dfbc133ca3f24',
        'name': 'Jefferson Crosby',
        'age': 18,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e59688fed8733fe8db',
        'name': 'Gregory Rush',
        'age': 18,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e50c8f319f551bf92b',
        'name': 'Davis Porter',
        'age': 13,
        'class': 'Science',
        'grade': 'A'
    },
    {
        'id': '5f5e67e58210b3a4221a5e1f',
        'name': 'Rios Morris',
        'age': 14,
        'class': 'Music',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5e050137f22c2b496',
        'name': 'Haynes Odonnell',
        'age': 15,
        'class': 'Science',
        'grade': 'D'
    },
    {
        'id': '5f5e67e574a04456de49063b',
        'name': 'Berger Martin',
        'age': 13,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5ba600d48660c5892',
        'name': 'Valencia Howe',
        'age': 18,
        'class': 'English',
        'grade': 'A'
    },
    {
        'id': '5f5e67e541c7691b3499cf98',
        'name': 'Benjamin Hurst',
        'age': 15,
        'class': 'Music',
        'grade': 'C'
    },
    {
        'id': '5f5e67e54f218304fb97a20c',
        'name': 'Jaime Rowland',
        'age': 12,
        'class': 'Science',
        'grade': 'D'
    },
    {
        'id': '5f5e67e55ab58e97231535a7',
        'name': 'Faye Walter',
        'age': 18,
        'class': 'English',
        'grade': 'B'
    },
    {
        'id': '5f5e67e58c30e40eac961e6a',
        'name': 'Viola Burks',
        'age': 17,
        'class': 'English',
        'grade': 'C'
    },
    {
        'id': '5f5e67e59f8ffd2a677c745b',
        'name': 'Willa Boyd',
        'age': 13,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5060d385420340bf7',
        'name': 'Bridges Sosa',
        'age': 12,
        'class': 'English',
        'grade': 'B'
    },
    {
        'id': '5f5e67e500c8e153141f9848',
        'name': 'Austin Morin',
        'age': 12,
        'class': 'Music',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5ed5da58372514b72',
        'name': 'Melisa Walker',
        'age': 15,
        'class': 'English',
        'grade': 'A'
    },
    {
        'id': '5f5e67e586db2c1d68950deb',
        'name': 'Neva Greer',
        'age': 14,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5f4aa535e99d71c30',
        'name': 'Rosalyn Whitley',
        'age': 13,
        'class': 'English',
        'grade': 'D'
    },
    {
        'id': '5f5e67e580bae7810b7d3af7',
        'name': 'Vicki Battle',
        'age': 13,
        'class': 'Science',
        'grade': 'C'
    },
    {
        'id': '5f5e67e54cc71aa24796cbd5',
        'name': 'Richards Hunter',
        'age': 13,
        'class': 'Math',
        'grade': 'C'
    },
    {
        'id': '5f5e67e549974ee9033857ef',
        'name': 'Loraine Perez',
        'age': 17,
        'class': 'English',
        'grade': 'A'
    },
    {
        'id': '5f5e67e52ea914bbc62800e3',
        'name': 'Wilder Mcdaniel',
        'age': 17,
        'class': 'Music',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5ba4c09c4d2830cca',
        'name': 'Sloan Bowman',
        'age': 16,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e53bafe1edb20e0da1',
        'name': 'Ford Davidson',
        'age': 15,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e51494e49128308d15',
        'name': 'Beasley Cohen',
        'age': 12,
        'class': 'English',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5706bb082aeb18f73',
        'name': 'Roberta Jensen',
        'age': 13,
        'class': 'Music',
        'grade': 'D'
    },
    {
        'id': '5f5e67e575b122a091f162b4',
        'name': 'Estrada Vaughn',
        'age': 14,
        'class': 'Science',
        'grade': 'D'
    },
    {
        'id': '5f5e67e552bd2e2574ebf4d6',
        'name': 'Rosales Boyle',
        'age': 15,
        'class': 'Science',
        'grade': 'B'
    },
    {
        'id': '5f5e67e52c644df337b65e02',
        'name': 'Cochran Butler',
        'age': 12,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e580f036bf66d9cf2a',
        'name': 'Ursula Boyer',
        'age': 14,
        'class': 'English',
        'grade': 'D'
    },
    {
        'id': '5f5e67e5f00da6be5d0ddfd5',
        'name': 'Sawyer Castillo',
        'age': 16,
        'class': 'Music',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5bcb40601855cb441',
        'name': 'Maryellen Sims',
        'age': 14,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e543e6e0f7eef9a4fd',
        'name': 'Aguilar Bates',
        'age': 17,
        'class': 'English',
        'grade': 'D'
    },
    {
        'id': '5f5e67e5cb2956cc11b0daa2',
        'name': 'Genevieve Morrison',
        'age': 14,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5af6db36231c912e6',
        'name': 'Judith Spencer',
        'age': 15,
        'class': 'Music',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5ba31ebf705920214',
        'name': 'Donna Doyle',
        'age': 14,
        'class': 'Math',
        'grade': 'D'
    },
    {
        'id': '5f5e67e562612a24bf7b232b',
        'name': 'Debbie Strickland',
        'age': 17,
        'class': 'Music',
        'grade': 'B'
    },
    {
        'id': '5f5e67e504307c8ee56b0fcf',
        'name': 'Michael Mcdonald',
        'age': 13,
        'class': 'Science',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5384fb735dca025de',
        'name': 'Anne Roy',
        'age': 17,
        'class': 'Math',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5c24c7aab7e3ab4ae',
        'name': 'Melva Simpson',
        'age': 16,
        'class': 'Science',
        'grade': 'D'
    },
    {
        'id': '5f5e67e5bce98dc86be02730',
        'name': 'Spears Nelson',
        'age': 18,
        'class': 'Math',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5be18347e6f97c7f9',
        'name': 'Raquel Gutierrez',
        'age': 16,
        'class': 'Music',
        'grade': 'D'
    },
    {
        'id': '5f5e67e53aed6e3f4e85aa5b',
        'name': 'Kirk David',
        'age': 17,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5ca3e4b8c424aea50',
        'name': 'Sondra Mullen',
        'age': 15,
        'class': 'Math',
        'grade': 'C'
    },
    {
        'id': '5f5e67e54c02612fe6e5e56d',
        'name': 'Jones Cooper',
        'age': 13,
        'class': 'English',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5a241e82fea2e20e6',
        'name': 'Vang Sloan',
        'age': 14,
        'class': 'Music',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5c89ddcdb68b1b9b6',
        'name': 'Stewart Chase',
        'age': 14,
        'class': 'Science',
        'grade': 'A'
    },
    {
        'id': '5f5e67e546cf06bd7d2294b4',
        'name': 'Wilkins Gilbert',
        'age': 16,
        'class': 'Science',
        'grade': 'B'
    },
    {
        'id': '5f5e67e50c42b85cba22880c',
        'name': 'Mccarty Green',
        'age': 16,
        'class': 'Science',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5e92ee09224ae3f9f',
        'name': 'Katina Osborne',
        'age': 15,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e54a9aa9099c6b1bc9',
        'name': 'Callahan Carlson',
        'age': 17,
        'class': 'Music',
        'grade': 'B'
    },
    {
        'id': '5f5e67e581e53ec9ac9b7a2b',
        'name': 'Kim Levine',
        'age': 14,
        'class': 'Math',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5f06c5860eaae043c',
        'name': 'Madge William',
        'age': 14,
        'class': 'Science',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5dbeb2d4a7a1dbbc7',
        'name': 'Miles Patterson',
        'age': 14,
        'class': 'Math',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5a09d4fe46d8a8fe2',
        'name': 'Susanne Avery',
        'age': 12,
        'class': 'Math',
        'grade': 'D'
    },
    {
        'id': '5f5e67e56c37e68f3105669c',
        'name': 'Burks Bridges',
        'age': 16,
        'class': 'English',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5dff5797a56546f66',
        'name': 'Leona Dean',
        'age': 16,
        'class': 'Music',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5b1314f8ce5fafff2',
        'name': 'Robin Hall',
        'age': 18,
        'class': 'English',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5a70acc2b455c9d91',
        'name': 'Patty Olsen',
        'age': 13,
        'class': 'Science',
        'grade': 'A'
    },
    {
        'id': '5f5e67e55f3334810f50ea59',
        'name': 'Kerry Rivas',
        'age': 17,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e57ee8c2f1f28369f4',
        'name': 'Yesenia Carey',
        'age': 14,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5c643a02c65f2953d',
        'name': 'Charlene Chandler',
        'age': 18,
        'class': 'Science',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5a645f223bb7d2b8a',
        'name': 'Isabella Camacho',
        'age': 14,
        'class': 'Music',
        'grade': 'B'
    },
    {
        'id': '5f5e67e54f99460706ff1cf4',
        'name': 'Baxter Cabrera',
        'age': 14,
        'class': 'English',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5a3206d3b3ad3bcf5',
        'name': 'Park Buckley',
        'age': 14,
        'class': 'Math',
        'grade': 'C'
    },
    {
        'id': '5f5e67e52dbb52a40cb6c774',
        'name': 'Mosley Ramsey',
        'age': 12,
        'class': 'English',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5e5eed8dc6efd3fd6',
        'name': 'Maureen Carver',
        'age': 12,
        'class': 'Music',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5014213895d3f4607',
        'name': 'Woodward Fitzpatrick',
        'age': 16,
        'class': 'Music',
        'grade': 'D'
    },
    {
        'id': '5f5e67e5f55bafadca2c2e38',
        'name': 'Moreno Ballard',
        'age': 16,
        'class': 'Science',
        'grade': 'B'
    },
    {
        'id': '5f5e67e59dbbd24a51bbd4eb',
        'name': 'Michael Dorsey',
        'age': 18,
        'class': 'English',
        'grade': 'D'
    },
    {
        'id': '5f5e67e5f3d5cc9b2e7763df',
        'name': 'Marianne Santiago',
        'age': 13,
        'class': 'Math',
        'grade': 'A'
    },
    {
        'id': '5f5e67e588882ff5fa52484e',
        'name': 'Cohen Osborn',
        'age': 15,
        'class': 'Math',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5638bdb2dc75119a2',
        'name': 'Harper Huber',
        'age': 14,
        'class': 'Math',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5edfdeef08091ed71',
        'name': 'Yates Nielsen',
        'age': 18,
        'class': 'Music',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5c1ba3410c192d8ed',
        'name': 'Petty Conley',
        'age': 14,
        'class': 'Science',
        'grade': 'B'
    },
    {
        'id': '5f5e67e525d1c270c07436c3',
        'name': 'Drake Santana',
        'age': 13,
        'class': 'English',
        'grade': 'B'
    },
    {
        'id': '5f5e67e56be38fc948a7556d',
        'name': 'Randi Wise',
        'age': 13,
        'class': 'English',
        'grade': 'B'
    },
    {
        'id': '5f5e67e503e5151f520b8ff0',
        'name': 'Francis Jacobs',
        'age': 16,
        'class': 'Music',
        'grade': 'B'
    },
    {
        'id': '5f5e67e5f00c538c78a8453d',
        'name': 'Small Brock',
        'age': 18,
        'class': 'Math',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5149a553e8bd0f165',
        'name': 'Hazel Cobb',
        'age': 14,
        'class': 'Math',
        'grade': 'C'
    },
    {
        'id': '5f5e67e59869ee4e0bee41df',
        'name': 'Frederick Robles',
        'age': 17,
        'class': 'Music',
        'grade': 'C'
    },
    {
        'id': '5f5e67e58eae9bce8ae6dd11',
        'name': 'Saundra Mooney',
        'age': 14,
        'class': 'Science',
        'grade': 'C'
    },
    {
        'id': '5f5e67e5dce4dcc96920a968',
        'name': 'Audra Suarez',
        'age': 14,
        'class': 'English',
        'grade': 'A'
    },
    {
        'id': '5f5e67e5470306a5080f20b4',
        'name': 'Louella Mcmillan',
        'age': 12,
        'class': 'Science',
        'grade': 'C'
    },
    {
        'id': '5f5e67e541853db29df06332',
        'name': 'Joseph Hinton',
        'age': 17,
        'class': 'English',
        'grade': 'B'
    }
]";

    }
}
