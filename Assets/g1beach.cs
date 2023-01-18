using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g1beach : MonoBehaviour
{

    public List<string> GirlDialog = new List<string>();

    public List<int> LoseList = new List<int>() { 19 };

    public List<int> WinList = new List<int>() { 11 };

    public int winstep = 3;

    int childindex = 0;

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            string strn = "" + i;
            GirlDialog.Add(strn);

        }

        childindex = transform.GetSiblingIndex();



        //PlayerPrefs.SetString("language", "tr");




    }


    public void DialogLanguageEn()
    {
        if (PlayerPrefs.GetString("language") != "tr")
        {
            switch (PlayerPrefs.GetInt("girl"))
            {
                case 0:
                    {

                        girl1();
                        break;
                    }
                case 1:
                    {
                        Debug.Log("22");
                        girl2();
                        break;
                    }
                case 2:
                    {
                        Debug.Log("33");
                        girl3();
                        break;
                    }
                case 3:
                    {
                        Debug.Log("44");
                        girl4();
                        break;
                    }
                case 4:
                    {
                        girl5();
                        break;
                    }
                case 5:
                    {
                        girl6();
                        break;
                    }
                case 6: // park
                    {
                        girl7();
                        break;
                    }
                case 7:
                    {
                        girl8();
                        break;
                    }
                case 8:
                    {
                        girl9();
                        break;
                    }
                case 9:         //game center
                    {
                        girl10();
                        break;
                    }
                case 10:
                    {
                        girl11();
                        break;
                    }
                case 11:
                    {
                        girl12();
                        break;
                    }
                case 12:
                    {
                        girl13();
                        break;
                    }
                case 13:
                    {
                        girl14();
                        break;
                    }
                case 14:
                    {
                        girl15();
                        break;
                    }
                case 15:
                    {
                        girl16();
                        break;
                    }
                case 16:
                    {
                        girl17();
                        break;
                    }
                case 17:
                    {
                        girl18();
                        break;
                    }
                case 18:
                    {
                        girl19();
                        break;
                    }
                case 19:
                    {
                        girl20();
                        break;
                    }
                case 20:
                    {
                        girl21();
                        break;
                    }
                case 21:
                    {
                        girl22();
                        break;
                    }
                case 22:
                    {
                        girl23();
                        break;
                    }
                case 23:
                    {
                        girl24();
                        break;
                    }
                case 24:
                    {
                        girl25();
                        break;
                    }
                case 25:
                    {
                        girl26();
                        break;
                    }
                case 26:
                    {
                        girl27();
                        break;
                    }
                case 27:
                    {
                        girl28();
                        break;
                    }
                case 28:
                    {
                        girl29();
                        break;
                    }
                case 29:
                    {
                        girl30();
                        break;
                    }
                case 30:
                    {
                        girl31();
                        break;
                    }
                case 31:
                    {
                        girl32();
                        break;
                    }
                case 32:
                    {
                        girl33();
                        break;
                    }
                case 33:        // hospital
                    {
                        girl34();
                        break;
                    }
                case 34:
                    {
                        girl35();
                        break;
                    }
                case 35:
                    {
                        girl36();
                        break;
                    }
                case 36:
                    {
                        girl37();
                        break;
                    }
                case 37:
                    {
                        girl38();
                        break;
                    }
                case 38:
                    {
                        girl39();
                        break;
                    }


            }
        }
    }


    void girl1()
    {

        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Hello, I'm happy you came to the beach. What are you doing here?";
        GirlDialog[2] = "Isn't the weather really hot?";
        GirlDialog[3] = "The beach looks really swampy.";

        GirlDialog[4] = "I like walking on the beach on a beautiful day.";
        GirlDialog[5] = "Isn't the smell of this beach disturbing?";
        GirlDialog[6] = "The sun makes you feel good.";
        GirlDialog[7] = "This beach is really ugly.";

        GirlDialog[8] = "I completely agree with you. I'm a summer person.";
        GirlDialog[9] = "You must think highly of yourself.";
        GirlDialog[10] = "I'm a winter person.";
        GirlDialog[11] = "I think it's destiny that we met.";

        GirlDialog[12] = "I'm glad to have met you.";
        GirlDialog[13] = "This pleasure is mine.";
    }




    void girl2()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I know, you came here for me.";
        GirlDialog[2] = "Do you need sunscreen?";
        GirlDialog[3] = "Is this your first time here? Isn't the weather nice?";

        GirlDialog[4] = "Yes. I came here on vacation.";
        GirlDialog[5] = "What a coincidence, I'm here for the first time in years as well.";
        GirlDialog[6] = "You seem to be always traveling and getting dirty.";
        GirlDialog[7] = "I guess you have a lot of money.";

        GirlDialog[8] = "How nice, do you have any recommendations for things to do here on the beach?";
        GirlDialog[9] = "Be careful, there are a lot of sharks here.";
        GirlDialog[10] = "Being with me is my biggest recommendation.";
        GirlDialog[11] = "How about we have a coffee in the cafe up ahead?";

        GirlDialog[12] = "It sounds very appealing to me.";
        GirlDialog[13] = "You are more appealing.";
    }

    void girl3()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Are you having fun here?";
        GirlDialog[2] = "Good day, what are you doing on this beautiful day?";
        GirlDialog[3] = "Is that smell coming from you?";
        GirlDialog[4] = "I'm sunbathing. How about you?";

        GirlDialog[5] = "You've put a damper on my mood.";
        GirlDialog[6] = "This doesn't concern you.";
        GirlDialog[7] = "I think I'm having the best day of my vacation.";
        GirlDialog[8] = "That is interesting, Why?";

        GirlDialog[9] = "Talking to you is enough for that.";
        GirlDialog[10] = "Does this concern you?";
        GirlDialog[11] = "I'm actually keeping the answer to that a secret.";

        GirlDialog[12] = "You're very sweet. Thank you.";
        GirlDialog[13] = "It's wonderful to meet you.";

    }

    void girl4()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You're poorly dressed for this place.";
        GirlDialog[2] = "Are you an elite person?";
        GirlDialog[3] = "You are the most beautiful piece in this museum.";
        GirlDialog[4] = "Thank you. Are you interested in art?";

        GirlDialog[5] = "My great-grandparents were all artists.";
        GirlDialog[6] = "I come here to see beautiful women.";
        GirlDialog[7] = "I am art itself.";
        GirlDialog[8] = "You're really funny.";

        GirlDialog[9] = "Yes, I am.";
        GirlDialog[10] = "What's funny about that?";
        GirlDialog[11] = "I'm happy to have made you smile.";

        GirlDialog[12] = "I think it's my lucky day.";
        GirlDialog[13] = "I feel like I've won the lottery.";

    }

    void girl6()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "What are you looking for in the museum?";
        GirlDialog[2] = "What's the most interesting thing you've seen in this museum?";
        GirlDialog[3] = "Museums don't seem to be your thing.";
        GirlDialog[4] = "The antique Chinese vases looked very beautiful.";

        GirlDialog[5] = "You look more antique.";
        GirlDialog[6] = "I didn't particularly like those antiques.";
        GirlDialog[7] = "I can't believe it. I agree with you.";
        GirlDialog[8] = "Our meeting here must be fate.";
        GirlDialog[9] = "I believe in fate. I feel something different now.";
        GirlDialog[10] = "Fate seems a bit ridiculous to me.";
        GirlDialog[11] = "I don't think you're very smart.";
        GirlDialog[12] = "I'm glad we met.";
        GirlDialog[13] = "May our happiness last forever.";

    }

    void girl5()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "These museums are so expensive.";
        GirlDialog[2] = "Hello, do you know how old this museum is?";
        GirlDialog[3] = "Don't museums seem meaningless?";
        GirlDialog[4] = "How old?";
        GirlDialog[5] = "The oldest pieces date back to pre-millennial years.";
        GirlDialog[6] = "I don't know either.";
        GirlDialog[7] = "You seem quite ignorant.";
        GirlDialog[8] = "You seem very knowledgeable. I am impressed.";
        GirlDialog[9] = "How about we have a coffee after the museum?";
        GirlDialog[10] = "I am very impressive.";
        GirlDialog[11] = "I leave such an impact on women.";
        GirlDialog[12] = "Sounds Great";
        GirlDialog[13] = "We have a deal then.";


    }

    void girl7()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Is that smell coming from you?";
        GirlDialog[2] = "This park is really creepy.";
        GirlDialog[3] = "It's a beautiful evening, isn't it?";
        GirlDialog[4] = "Yes, the weather is great.";
        GirlDialog[5] = "Do you want to run a race?";
        GirlDialog[6] = "You're very beautiful.";
        GirlDialog[7] = "You're what makes this place beautiful.";
        GirlDialog[8] = "Thank you.";
        GirlDialog[9] = "Do you want to go for a walk here tomorrow?";
        GirlDialog[10] = "You're so cold.";
        GirlDialog[11] = "Your glasses look funny.";
        GirlDialog[12] = "Definitely, let's do that.";
        GirlDialog[13] = "I'm glad we met.";
    }

    void girl8()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Are you the angel of this park?";
        GirlDialog[2] = "Shall we have a coffee?";
        GirlDialog[3] = "Isn't this a great park?";
        GirlDialog[4] = "This is my favorite park in the city.";
        GirlDialog[5] = "This is a great choice for relieving the stress of the city.";
        GirlDialog[6] = "Are you maybe exaggerating a bit?";
        GirlDialog[7] = "I know a better place.";
        GirlDialog[8] = "It really is, quiet and enchanting.";
        GirlDialog[9] = "You're funny.";
        GirlDialog[10] = "Is it the park or you?";
        GirlDialog[11] = "Come on, let me buy you to a meal.";
        GirlDialog[12] = "You're sweet. Thank you.";
        GirlDialog[13] = "I'm very glad to met you.";
    }

    void girl9()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Did you get lost?";
        GirlDialog[2] = "Are you taking a walk";
        GirlDialog[3] = "You're very beautiful.";
        GirlDialog[4] = "Yes. Why?";
        GirlDialog[5] = "I go for a walk here every day. I've never seen you before.";
        GirlDialog[6] = "You're walking slowly.";
        GirlDialog[7] = "You need to lose some weight.";
        GirlDialog[8] = "I came here on vacation.";
        GirlDialog[9] = "I hope the vacation ends soon.";
        GirlDialog[10] = "I didn't ask that.";
        GirlDialog[11] = "This park is very beautiful, it's even more beautiful with you.";
        GirlDialog[12] = "Thank you. You made me feel good.";
        GirlDialog[13] = "I'm glad you think like that.";
    }

    void girl10()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "This arcade must be boring.";
        GirlDialog[2] = "This place is not for you.";
        GirlDialog[3] = "I'm new here. Do you have any recommendations for a game?";
        GirlDialog[4] = "Sure. What kind of games do you like?";
        GirlDialog[5] = "To be honest, I don't really like games.";
        GirlDialog[6] = "I'm good at all of them.";
        GirlDialog[7] = "I'll leave it up to your preference.";
        GirlDialog[8] = "In that case, I recommend the dance competition game.";
        GirlDialog[9] = "That game is only for girls.";
        GirlDialog[10] = "Why not if we play against each other?";
        GirlDialog[11] = "I didn't like this game.";
        GirlDialog[12] = "It looks like it will be fun.";
        GirlDialog[13] = "I feel the same way.";
    }
    void girl11()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Are you a wizard? Every time I look at you, everyone disappears.";
        GirlDialog[2] = "Are you part of the game here? You're too beautiful to be real.";
        GirlDialog[3] = "What game would you recommend for me to play?";
        GirlDialog[4] = "I love racing games.";
        GirlDialog[5] = "I'm not really into games to be honest.";
        GirlDialog[6] = "I play to win. Want to play together?";
        GirlDialog[7] = "I love racing games.";
        GirlDialog[8] = "Would you like to play together?";
        GirlDialog[9] = "If we're going to play, let's make it interesting and put a bet.";
        GirlDialog[10] = "I couldn't hear you because you are gorgeous";
        GirlDialog[11] = "With pleasure.";
        GirlDialog[12] = "Don't fall behind.";
        GirlDialog[13] = "I will always be by your side.";
    }

    void girl12()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You're really good. Can you give me some tips on the game?";
        GirlDialog[2] = "Are you a dream or a reality? Or is this just a game?";
        GirlDialog[3] = "The game I want to play is you.";
        GirlDialog[4] = "I am the champion of this game. Who are you?";
        GirlDialog[5] = "Let's say I'm a fan.";
        GirlDialog[6] = "That doesn't matter to me.";
        GirlDialog[7] = "You're the end of me.";
        GirlDialog[8] = "Very nice. What would you like to learn?";
        GirlDialog[9] = "I'm curious about attack strategies.";
        GirlDialog[10] = "Tell me how to beat you.";
        GirlDialog[11] = "Your phone number.";
        GirlDialog[12] = "I feel like want to play with you for hours.";
        GirlDialog[13] = "All of my time is yours.";
    }

    void girl13()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You look too weak for weights.";
        GirlDialog[2] = "I can't workout looking at you.";
        GirlDialog[3] = "I haven't seen you here before.";
        GirlDialog[4] = "I just moved to this town.";
        GirlDialog[5] = "This town is nice, I'm sure you'll love it.";
        GirlDialog[6] = "Actually we don't like new people in here.";
        GirlDialog[7] = "Or were you kicked out of your old town?";
        GirlDialog[8] = "I already started to love you.";
        GirlDialog[9] = "What do you say we take a walk together after sports?";
        GirlDialog[10] = "Actually, ballet would suit you more.";
        GirlDialog[11] = "Is that sweat smell coming from you?";
        GirlDialog[12] = "That would be nice.";
        GirlDialog[13] = "Alright, it's a deal.";
    }
    void girl14()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You must run for hours on the treadmill.";
        GirlDialog[2] = "How much do you weigh?";
        GirlDialog[3] = "Could I see you in a yoga class?";
        GirlDialog[4] = "No, I don't take yoga classes.";
        GirlDialog[5] = "You didn't need to lie to me.";
        GirlDialog[6] = "I never forget what I see.";
        GirlDialog[7] = "This flexibility must be natural.";
        GirlDialog[8] = "Thank you. Will you come here often?";
        GirlDialog[9] = "I am not a guest like you. I live here.";
        GirlDialog[10] = "I'm thinking of coming here every day to see you.";
        GirlDialog[11] = "I hate sports. But there are beautiful women here.";
        GirlDialog[12] = "Thank you. I would like to see you.";
        GirlDialog[13] = "Gladly.";
    }

    void girl15()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Is that sweat smell coming from you?";
        GirlDialog[2] = "Hello, how many sets do you have left?";
        GirlDialog[3] = "If you're tired, I can give you a ride home.";
        GirlDialog[4] = "I have 2 sets left. Why?";
        GirlDialog[5] = "I've been waiting for you to finish for hours.";
        GirlDialog[6] = "When you finish, can you give me some tips on exercises?";
        GirlDialog[7] = "I was wondering when you're leaving.";
        GirlDialog[8] = "Of course. I'd love to help.";
        GirlDialog[9] = "As a favor, I'd like to buy you a coffee.";
        GirlDialog[10] = "Do you think you're very attractive?";
        GirlDialog[11] = "Did you get excited when you saw me?";
        GirlDialog[12] = "Why don't we have a drink together?";
        GirlDialog[13] = "With pleasure.";
    }

    void girl16()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I can get you something to eat if you want.";
        GirlDialog[2] = "Hello, which clothing store do you recommend?";
        GirlDialog[3] = "Get out of my way.";
        GirlDialog[4] = "Hello, what type of style do you like to wear?";
        GirlDialog[5] = "Dress me.";
        GirlDialog[6] = "I don't really like getting dressed up.";
        GirlDialog[7] = "I'm curious about your advice.";
        GirlDialog[8] = "If you want, we can go shopping together.";
        GirlDialog[9] = "You seem very enthusiastic.";
        GirlDialog[10] = "Are you a gold digger?";
        GirlDialog[11] = "I'd be very happy. It looks like it will be fun.";
        GirlDialog[12] = "I completely agree with you.";
        GirlDialog[13] = "Let's go then.";
    }

    void girl17()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I didn't like your style very much.";
        GirlDialog[2] = "How much money do you have?";
        GirlDialog[3] = "Time stood still when I saw you.";
        GirlDialog[4] = "Why is that?";
        GirlDialog[5] = "You're not romantic.";
        GirlDialog[6] = "I need to ask this to your eyes.";
        GirlDialog[7] = "You're very beautiful because of it.";
        GirlDialog[8] = "You're really fun.";
        GirlDialog[9] = "Do you want to explore this mall together?";
        GirlDialog[10] = "Come on, let's waste time till morning.";
        GirlDialog[11] = "You might be like that too.";
        GirlDialog[12] = "Awesome idea.";
        GirlDialog[13] = "I'm really glad to have met you.";
    }

    void girl18()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Do you enjoy spending money a lot?";
        GirlDialog[2] = "Is exploring the mall a form of meditation for you?";
        GirlDialog[3] = "Look at me closely.";
        GirlDialog[4] = "It relaxes me a lot. What about you?";
        GirlDialog[5] = "I really forget all my troubles.";
        GirlDialog[6] = "I'm scared my money will decrease.";
        GirlDialog[7] = "There are beautiful women in the mall.";
        GirlDialog[8] = "I'm glad we have the same opinion.";
        GirlDialog[9] = "Can I buy you a coffee on the top floor?";
        GirlDialog[10] = "You are so easy to pick up.";
        GirlDialog[11] = "You're so beautiful, you look like a model.";
        GirlDialog[12] = "Why not? I'm glad we met.";
        GirlDialog[13] = "I'm also very happy.";
    }

    void girl19()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Let's not read books and watch a movie.";
        GirlDialog[2] = "Are you stealing a book?";
        GirlDialog[3] = "What is your favorite book genre?";
        GirlDialog[4] = "I love history books.";
        GirlDialog[5] = "What a coincidence, me too.";
        GirlDialog[6] = "You seem very uninteresting.";
        GirlDialog[7] = "I think history is very common.";
        GirlDialog[8] = "Meeting someone who loves books is very nice.";
        GirlDialog[9] = "You're easy to deceive.";
        GirlDialog[10] = "Come over to my place and we'll read books together.";
        GirlDialog[11] = "Do you want to walk together when we're done?";
        GirlDialog[12] = "I'd be very happy.";
        GirlDialog[13] = "Our plan is set then.";
    }

    void girl20()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Reading books is a waste of time.";
        GirlDialog[2] = "The dust on these shelves will make us sick.";
        GirlDialog[3] = "I'm new here, can you help me?";
        GirlDialog[4] = "Sure, what do you need?";
        GirlDialog[5] = "I need to learn how to approach you.";
        GirlDialog[6] = "Where are the romance novels located?";
        GirlDialog[7] = "I need you.";
        GirlDialog[8] = "I also enjoy reading romance novels.";
        GirlDialog[9] = "Maybe our meeting is like the first page of a novel.";
        GirlDialog[10] = "I need to learn how to pick up girls.";
        GirlDialog[11] = "I'm not surprised.";
        GirlDialog[12] = "You're very romantic. I'm glad I met you.";
        GirlDialog[13] = "You became my happiness.";
    }

    void girl21()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "This place is not for you.";
        GirlDialog[2] = "Do you think you are too smart?";
        GirlDialog[3] = "I'm glad I saw you here.";
        GirlDialog[4] = "Why is that?";
        GirlDialog[5] = "Because the library is more beautiful with you.";
        GirlDialog[6] = "It doesn't concern you.";
        GirlDialog[7] = "Giving a short answer is rude.";
        GirlDialog[8] = "You're really sweet.";
        GirlDialog[9] = "Shall we crown our meeting with a sweet?";
        GirlDialog[10] = "Yes but.You are not.";
        GirlDialog[11] = "I know you don't have to tell me.";
        GirlDialog[12] = "I'm glad we met.";
        GirlDialog[13] = "That happiness is mine.";
    }

    void girl22()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I'm sure you're afraid of flying.";
        GirlDialog[2] = "Hello, which country are you going to?";
        GirlDialog[3] = "I wrote your name in the sky. You haven't read it.";
        GirlDialog[4] = "I haven't decided yet. Why?";
        GirlDialog[5] = "I'll ask you what I want.";
        GirlDialog[6] = "I'm thinking about missing you.";
        GirlDialog[7] = "Our meeting must be fate.";
        GirlDialog[8] = "I actually believe in fate.";
        GirlDialog[9] = "Shall we go to a city together and take a vacation?";
        GirlDialog[10] = "Only fools believe in fate.";
        GirlDialog[11] = "There is no such thing as fate.";
        GirlDialog[12] = "It would be very exciting. I'd love that.";
        GirlDialog[13] = "A great adventure awaits us.";
    }

    void girl23()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I am a hijacker. Should we hijack the plane?";
        GirlDialog[2] = "Your luggage looks very low quality.";
        GirlDialog[3] = "Hello, are you in a hurry?";
        GirlDialog[4] = "Hello, no actually. Why did you ask?";
        GirlDialog[5] = "I missed my flight. I'm very upset.";
        GirlDialog[6] = "You can meet me then.";
        GirlDialog[7] = "I asked to give you a chance.";
        GirlDialog[8] = "I'm really sorry.";
        GirlDialog[9] = "You didn't help at all.";
        GirlDialog[10] = "You're very cold.";
        GirlDialog[11] = "Meeting you was very good.";
        GirlDialog[12] = "I feel the same. You were good to me.";
        GirlDialog[13] = "Let's always be good to each other then.";
    }

    void girl24()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Did you take my suitcase?";
        GirlDialog[2] = "Have you seen a blue suitcase here?";
        GirlDialog[3] = "You look like a suitcase thief.";
        GirlDialog[4] = "No, I haven't. Did you lose your suitcase?";
        GirlDialog[5] = "Yes but it's not important.";
        GirlDialog[6] = "I had to ask you this.";
        GirlDialog[7] = "Don't give silly answers. Otherwise, why would I ask?";
        GirlDialog[8] = "That's very bad. Why did you say that?";
        GirlDialog[9] = "Because meeting you was an opportunity.";
        GirlDialog[10] = "I have a lot of money, it won't be a problem.";
        GirlDialog[11] = "I will use your suitcase.";
        GirlDialog[12] = "This coincidence was very nice.";
        GirlDialog[13] = "You are the best coincidence.";
    }

    void girl25()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I have been looking for it but I can't find it.";
        GirlDialog[2] = "You can buy me a drink.";
        GirlDialog[3] = "Are you drunk?";
        GirlDialog[4] = "What are you looking for?";
        GirlDialog[5] = "I'm looking for an excuse to meet you.";
        GirlDialog[6] = "Did you take my money?";
        GirlDialog[7] = "I'm looking for a beautiful girl while drunk.";
        GirlDialog[8] = "You're very sweet. I think you the excuse.";
        GirlDialog[9] = "I easily charmed you.";
        GirlDialog[10] = "Did you fall in love with me when you saw me?";
        GirlDialog[11] = "If that's the case, can I accompany you?";
        GirlDialog[12] = "I am pleased.";
        GirlDialog[13] = "This pleasure belongs to me.";
    }

    void girl26()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You've been drinking a lot today, haven't you?";
        GirlDialog[2] = "I have a lot of money. Should we get to know each other?";
        GirlDialog[3] = "Hello, can I accompany you?";
        GirlDialog[4] = "Sure. We can share the table.";
        GirlDialog[5] = "If you also have a lot of money, buy me a drink.";
        GirlDialog[6] = "You're not dressed well for this place.";
        GirlDialog[7] = "Tell me about yourself, I want to get to know you.";
        GirlDialog[8] = "I really want to. Meeting you was nice.";
        GirlDialog[9] = "Isn't the girl at the next table very beautiful?";
        GirlDialog[10] = "Can you give me your number? I want to see you again tomorrow.";
        GirlDialog[11] = "Because I am amazing.";
        GirlDialog[12] = "I want to see you again tomorrow.";
        GirlDialog[13] = "We have a great start.";
    }

    void girl27()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Hello, how do you like this bar?";
        GirlDialog[2] = "What are you doing in this terrible place?";
        GirlDialog[3] = "Can you give me your number?";
        GirlDialog[4] = "This is my favorite bar.";
        GirlDialog[5] = "I couldn't trust your recommendation.";
        GirlDialog[6] = "I'm here for the first time, do you have any recommendations?";
        GirlDialog[7] = "Since that's the case, come with me from now on.";
        GirlDialog[8] = "I love everything here.";
        GirlDialog[9] = "You don't seem to have many criteria.";
        GirlDialog[10] = "You didn't give me much confidence.";
        GirlDialog[11] = "You place the order and surprise me.";
        GirlDialog[12] = "Of course, welcome to my table.";
        GirlDialog[13] = "I'm glad we met.";
    }
    void girl28()               // market
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Can I buy you a salad?";
        GirlDialog[2] = "What's up, baby?";
        GirlDialog[3] = "Where is the chips aisle?";
        GirlDialog[4] = "It's in the back. I'm heading that way too.";
        GirlDialog[5] = "What a nice coincidence. Do you like chips?";
        GirlDialog[6] = "I'm going alone.";
        GirlDialog[7] = "I don't need your help.";
        GirlDialog[8] = "Of course. I love eating while watching movies.";
        GirlDialog[9] = "You're going to gain a lot of weight.";
        GirlDialog[10] = "You're eating unhealthy.";
        GirlDialog[11] = "Shall we go to the movies after the grocery store?";
        GirlDialog[12] = "A new movie just came out. It'll be great.";
        GirlDialog[13] = "So we have a plan then.";
    }

    void girl29()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Hello, that product you bought was very low quality.";
        GirlDialog[2] = "You've bought some ridiculous products.";
        GirlDialog[3] = "What are you looking at?";
        GirlDialog[4] = "Have you used it before?";
        GirlDialog[5] = "I'm lying. I never forget what I see.";
        GirlDialog[6] = "I never forget what I see.";
        GirlDialog[7] = "I didn't like the taste of it.";
        GirlDialog[8] = "Thank you, what would you recommend?";
        GirlDialog[9] = "I don't have any other , but I'd like a coffee with you.";
        GirlDialog[10] = "You can find me a girl.";
        GirlDialog[11] = "I'll give other recommendations for money.";
        GirlDialog[12] = "I would like that too. I'm glad we met.";
        GirlDialog[13] = "That satisfaction is mine.";
    }



    void girl30()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You're as beautiful as a devil.";
        GirlDialog[2] = "Your makeup is too excessive.";
        GirlDialog[3] = "Hello, it's a beautiful day today.";
        GirlDialog[4] = "Why did you say that?";
        GirlDialog[5] = "Because I met you.";
        GirlDialog[6] = "I'll kidnap you today.";
        GirlDialog[7] = "Can't I say what I want?";
        GirlDialog[8] = "It's a beautiful day then.";
        GirlDialog[9] = "Shall we go to the theater after the market?";
        GirlDialog[10] = "You're very beautiful. Be mine.";
        GirlDialog[11] = "It's a great luck for you to meet me.";
        GirlDialog[12] = "Of course, I love going to the theater.";
        GirlDialog[13] = "A fun date awaits us.";
    }

    void girl31()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "This was my spot.";
        GirlDialog[2] = "Nice day for sunbathing.";
        GirlDialog[3] = "Will you be my holiday girlfriend?";
        GirlDialog[4] = "Yes, did you come to swim?";
        GirlDialog[5] = "Yes, I come here to swim every day.";
        GirlDialog[6] = "You are very smart.";
        GirlDialog[7] = "No, I came to pick you up.";
        GirlDialog[8] = "It's good that you swim frequently.";
        GirlDialog[9] = "Now my reason to come here is you.";
        GirlDialog[10] = "If I didn't swim every day I would be as heavy as you.";
        GirlDialog[11] = "You should be mine because of that.";
        GirlDialog[12] = "You are sweet. Let's meet here every day.";
        GirlDialog[13] = "You are the best part of my holiday.";
    }
    void girl32()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I'm sure you don't know how to swim.";
        GirlDialog[2] = "Let's sunbathe together?";
        GirlDialog[3] = "Have you been here before to swim?";
        GirlDialog[4] = "Yes, I come here regularly.";
        GirlDialog[5] = "There's no reason for me not to come here.";
        GirlDialog[6] = "Can you put sun cream on me?";
        GirlDialog[7] = "Do you want to slide down the water slide?";
        GirlDialog[8] = "But ,I am really scared.";
        GirlDialog[9] = "I will hold you.";
        GirlDialog[10] = "You are very scared.";
        GirlDialog[11] = "Then I will go alone.";
        GirlDialog[12] = "If you hold me, I won't be scared.";
        GirlDialog[13] = "Adventure awaits us.";
    }

    void girl33()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Dance with me.";
        GirlDialog[2] = "I want to swim with you.";
        GirlDialog[3] = "Your hair is very beautiful.";
        GirlDialog[4] = "Thank you.";
        GirlDialog[5] = "I'm new here, can I accompany you?";
        GirlDialog[6] = "I'm sure you'll love me.";
        GirlDialog[7] = "You're very cold.";
        GirlDialog[8] = "Sure, I'd love to.";
        GirlDialog[9] = "Shall we continue our conversation in the pool?";
        GirlDialog[10] = "Are you bored from here?";
        GirlDialog[11] = "If you want, let's go to my house later.";
        GirlDialog[12] = "It will be very fun.";
        GirlDialog[13] = "The pool will be very fun.";
    }
    
    void girl34()          // hospital
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Excuse me, have you seen the nurse?";
        GirlDialog[2] = "You smell very sweaty.";
        GirlDialog[3] = "You're dressed poorly for this place.";
        GirlDialog[4] = "Yes, she just passed by.";
        GirlDialog[5] = "What are you looking at, just help me.";
        GirlDialog[6] = "Your beauty has made my head spin.";
        GirlDialog[7] = "Were you the one sneezing a lot?";
        GirlDialog[8] = "You are so sweet.";
        GirlDialog[9] = "Would you like to have a coffee at the cafeteria?";
        GirlDialog[10] = "You will fall in love with me.";
        GirlDialog[11] = "I tell this to every girl.";
        GirlDialog[12] = "I would like that. Good idea.";
        GirlDialog[13] = "We have agreed then.";
    }

    void girl35()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "You're making too much noise.";
        GirlDialog[2] = "You should be quiet in the hospital.";
        GirlDialog[3] = "I compared your voice to someone's.";
        GirlDialog[4] = "Interesting, who did you compare it to?";
        GirlDialog[5] = "You talk like an angel in my dreams.";
        GirlDialog[6] = "I compared it to the sound of monkeys.";
        GirlDialog[7] = "You have a devilish tone of voice.";
        GirlDialog[8] = "You're very sweet. You made me happy.";
        GirlDialog[9] = "You don't deserve happiness.";
        GirlDialog[10] = "In return you can hug me.";
        GirlDialog[11] = "I always want you to laugh.";
        GirlDialog[12] = "Nice to meet you.";
        GirlDialog[13] = "I'm also very pleased.";
    }
    void girl36()
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "I have something in my heart.";
        GirlDialog[2] = "This hospital is very bad.";
        GirlDialog[3] = "You should go to a makeup course.";
        GirlDialog[4] = "Can you call the doctor for me?";
        GirlDialog[5] = "If you give me your number, it will pass.";
        GirlDialog[6] = "The doctor can't heal me.";
        GirlDialog[7] = "You will be useful then.";
        GirlDialog[8] = "What do you mean, I don't understand.";
        GirlDialog[9] = "You're not very smart.";
        GirlDialog[10] = "I think I explained it clearly.";
        GirlDialog[11] = "You are in my heart.";
        GirlDialog[12] = "You are sweet. You made me happy.";
        GirlDialog[13] = "The task is completed.";
    }

    void girl37()           // restorant
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Do you like the food here?";
        GirlDialog[2] = "This place is really bad.";
        GirlDialog[3] = "You're ruining the atmosphere here.";
        GirlDialog[4] = "This is my favorite place.";
        GirlDialog[5] = "Can you sit somewhere else? You're ruining my view.";
        GirlDialog[6] = "You're really tasteless.";
        GirlDialog[7] = "This place is now my favorite too.";
        GirlDialog[8] = "I'm happy to hear that.";
        GirlDialog[9] = "How old are you?";
        GirlDialog[10] = "You'll gain weight if you eat too much.";
        GirlDialog[11] = "You're very nice. You made my day.";
        GirlDialog[12] = "I'm happy we met.";
        GirlDialog[13] = "I'm happy too.";
    }

    void girl38()           // restorant
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Do you like the food here?";
        GirlDialog[2] = "This place is really bad.";
        GirlDialog[3] = "You're ruining the atmosphere here.";
        GirlDialog[4] = "This is my favorite place.";
        GirlDialog[5] = "Can you sit somewhere else? You're ruining my view.";
        GirlDialog[6] = "You're really tasteless.";
        GirlDialog[7] = "This place is now my favorite too.";
        GirlDialog[8] = "I'm happy to hear that.";
        GirlDialog[9] = "How old are you?";
        GirlDialog[10] = "You'll gain weight if you eat too much.";
        GirlDialog[11] = "You're very nice. You made my day.";
        GirlDialog[12] = "I'm happy we met.";
        GirlDialog[13] = "I'm happy too.";
    }

    void girl39()           // restorant
    {
        GirlDialog[0] = "What is your pick up line?";
        GirlDialog[1] = "Can I have the menu please?";
        GirlDialog[2] = "Can I order a coffee for you?";
        GirlDialog[3] = "Your eyes are very beautiful.";
        GirlDialog[4] = "I'm not a waiter.";
        GirlDialog[5] = "I expect you to serve me.";
        GirlDialog[6] = "Don't lie to me.";
        GirlDialog[7] = "I know you're not a waiter.";
        GirlDialog[8] = "I don't understand you.";
        GirlDialog[9] = "I opened this topic to get to know you.";
        GirlDialog[10] = "It's not that difficult actually.";
        GirlDialog[11] = "I'm not surprised.";
        GirlDialog[12] = "I wasn't expecting it. I'm glad we met.";
        GirlDialog[13] = "That pleasure is mine.";
    }

}


