using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SaveGroupInfo : IScriptable
	{
		[Ordinal(0)] 
		[RED("lifePath")] 
		public CEnum<inkLifePath> LifePath
		{
			get => GetPropertyValue<CEnum<inkLifePath>>();
			set => SetPropertyValue<CEnum<inkLifePath>>(value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public CUInt64 Timestamp
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(3)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(4)] 
		[RED("level")] 
		public CDouble Level
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(5)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("playthroughID")] 
		public CString PlaythroughID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("additionalContentIds")] 
		public CArray<CName> AdditionalContentIds
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public SaveGroupInfo()
		{
			PlayTime = 0.000000;
			PlaythroughTime = 0.000000;
			Level = 0.000000;
			AdditionalContentIds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
