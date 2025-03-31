<Border
StrokeShape="RoundRectangle 15"
StrokeThickness="0"
BackgroundColor="Goldenrod"
VerticalOptions="Start"
Margin="10,10,10,20">
<Grid ColumnDefinitions="*, 150"
RowDefinitions="*, Auto">
<VerticalStackLayout Grid.Row="0"
Grid.Column="0"
Spacing="8">
<Label Text="Offer"
VerticalOptions="Center"
FontSize="20"
FontAttributes="Bold"
Margin="10,10,0,5"/>
<Label Text="Grab the best offer"
Margin="10,0,20,20"/>
</VerticalStackLayout>
<Button Grid.Row="1"
Grid.Column="0"
Text="Get it now"
FontAttributes="Bold"
CornerRadius="22"
HorizontalOptions="Center"
VerticalOptions="Center"
BackgroundColor="PaleGoldenrod"
TextColor="Black"
Padding="20,0"
Margin="-50,50,30,20"/>
<Image Grid.Row="0" Grid.RowSpan="2"
Grid.Column="1"
Source="discount.png"
HeightRequest="150"
Margin="-10,5,10,20"/>
</Grid>
</Border>