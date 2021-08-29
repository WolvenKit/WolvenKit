using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddDevelopmentPointEffector : gameEffector
	{
		private CInt32 _amount;
		private CEnum<gamedataDevelopmentPointType> _type;
		private TweakDBID _tdbid;

		[Ordinal(0)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("tdbid")] 
		public TweakDBID Tdbid
		{
			get => GetProperty(ref _tdbid);
			set => SetProperty(ref _tdbid, value);
		}
	}
}
