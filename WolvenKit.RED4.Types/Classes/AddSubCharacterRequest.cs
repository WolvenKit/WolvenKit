using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddSubCharacterRequest : gameScriptableSystemRequest
	{
		private CWeakHandle<ScriptedPuppet> _subCharObject;

		[Ordinal(0)] 
		[RED("subCharObject")] 
		public CWeakHandle<ScriptedPuppet> SubCharObject
		{
			get => GetProperty(ref _subCharObject);
			set => SetProperty(ref _subCharObject, value);
		}
	}
}
