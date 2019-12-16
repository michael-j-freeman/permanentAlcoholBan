using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}


class StoryLoader {
  //handles file opening and creating the Linked list
  //for file in in folder
  //str comp the files
  //store in temp any links that dont yet have links
  //need an effective algorithim
}


class StoryEngine {

  public string name;
  public List<Interaction> allInteractions;
  public Interaction startInteraction, currentInteraction;

  public StoryEngine(string name, List<Interaction> allInteractions, Interaction startInteraction){
    this.allInteractions = allInteractions;
    this.name = name;
    this.startInteraction = startInteraction;
    //needs to find the start node, if there are multiple then needs to 
    //randomly chose one
  }

  public void tellStory(){
    //set current interaction to start interaciton
    this.currentInteraction = this.startInteraction;
    //start walking through
    while(!currentInteraction.isEnd()){
      //wait for user input
      //then move to next interaction and re setup the current interaciton
      Console.WriteLine(this.currentInteraction.printOptions());
      Console.WriteLine("What option (0-3)?");
      string choiceStr = Console.ReadLine();
      int choiceInt = 0;
      Int32.TryParse(choiceStr, out choiceInt);
      this.currentInteraction = this.currentInteraction.nextInteraction(choiceInt);
    }
  }

}


class Interaction {
  public string prompt;
  public List<Link> links;
  public bool activated;
  public bool endFlag, startFlag;
  //fuck flags

  public Interaction(string prompt, List<Link> links){
    this.prompt = prompt;
    this.links = links;
    //here we would check for flags and if its a start flag, then activated
    this.activated = false;
  }

  public Interaction nextInteraction(int choice){
    return links[choice].getInteraction();
  }

  public string printOptions(){
    string temp = this.prompt + '\n';
    for(int i = 0; i<4; i++){
      temp = temp + '(' + i + ')' + links[0].getChoice() + '\n';
    }
    return temp;
  }

  public bool isEnd(){
    return endFlag;
  }

}

//start somewhere, when link is chosen, then set new interaction to activated
//print prompt and offer options

class Link {
  public Interaction interaction;
  public string choice;

  public Link(Interaction interaction, string choice){
    this.interaction = interaction;
    this.choice = choice;
  }

  public Interaction getInteraction(){
    return this.interaction;
  }

  public string getChoice(){
    return this.choice;
  }
}
