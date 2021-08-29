using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIObjectScriptBase : IScriptable
	{
		private CHandle<gameObject> _gameObject;

		[Ordinal(0)] 
		[RED("gameObject")] 
		public CHandle<gameObject> GameObject
		{
			get => GetProperty(ref _gameObject);
			set => SetProperty(ref _gameObject, value);
		}
	}
}
