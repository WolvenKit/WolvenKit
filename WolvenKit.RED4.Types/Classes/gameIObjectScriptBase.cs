using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIObjectScriptBase : IScriptable
	{
		[Ordinal(0)] 
		[RED("gameObject")] 
		public CHandle<gameObject> GameObject
		{
			get => GetPropertyValue<CHandle<gameObject>>();
			set => SetPropertyValue<CHandle<gameObject>>(value);
		}
	}
}
