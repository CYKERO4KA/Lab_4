namespace Lab_4;

class BicycleImages
{
    public string DrawFullBicycle()
    {
        return @"
                              __
                   ,--.      <__)
                   `- |________7
                      |`.      |\
                   .--|. \     |.\--.
                  /   j \ `.7__j__\  \
                 |   o   | (o)____O)  |
                  \     /   J  \     /
                   `---'        `---'      

";
    }
        
    public string DrawLeftWheelBicycle()
    {
        return @"
                              __
                   ,--.      <__)
                   `- |________7
                      |`.      |\
                   .--|. \     | \
                  /   j \ `.7__j__\  
                 |   o   | (o)____O)  
                  \     /   J     
                   `---'              

";
    }
    public string DrawRightWheelBicycle()
    {
        return @"
                              __
                   ,--.      <__)
                   `- |________7
                      |`.      |\
                      |. \     |.\--.
                      j   `.7__j__\  \
                           (o)____O)  |
                            J  \     /
                                `---'      

";
    }
    public string DrawNullWheelBicycle()
    {
        return @"
                              __
                   ,--.      <__)
                   `- |________7
                      |`.      |\
                      |. \     | \
                      j   `.7__j__\  
                           (o)____O)  
                            J       
                                      

";
    }
}