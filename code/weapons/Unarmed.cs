using Sandbox;

[Spawnable]
[Library( "weapon_unarmed", Title = "Unarmed" )]
partial class Unarmed : Weapon
{

    public override void ActiveStart( Entity ent )
    {
        base.ActiveStart(ent);
        Log.Info(this.ClassName + " equipped by ["+ent+"]");
        
    }

}