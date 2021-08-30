using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AreaEffectTargetData : IScriptable
	{
		private CName _areaEffectID;
		private CBool _onSelf;
		private CBool _onSlaves;

		[Ordinal(0)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get => GetProperty(ref _areaEffectID);
			set => SetProperty(ref _areaEffectID, value);
		}

		[Ordinal(1)] 
		[RED("onSelf")] 
		public CBool OnSelf
		{
			get => GetProperty(ref _onSelf);
			set => SetProperty(ref _onSelf, value);
		}

		[Ordinal(2)] 
		[RED("onSlaves")] 
		public CBool OnSlaves
		{
			get => GetProperty(ref _onSlaves);
			set => SetProperty(ref _onSlaves, value);
		}

		public AreaEffectTargetData()
		{
			_onSelf = true;
		}
	}
}
