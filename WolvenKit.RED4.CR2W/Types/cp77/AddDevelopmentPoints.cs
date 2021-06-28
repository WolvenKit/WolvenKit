using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddDevelopmentPoints : gamePlayerScriptableSystemRequest
	{
		private CInt32 _amountOfPoints;
		private CEnum<gamedataDevelopmentPointType> _developmentPointType;

		[Ordinal(1)] 
		[RED("amountOfPoints")] 
		public CInt32 AmountOfPoints
		{
			get => GetProperty(ref _amountOfPoints);
			set => SetProperty(ref _amountOfPoints, value);
		}

		[Ordinal(2)] 
		[RED("developmentPointType")] 
		public CEnum<gamedataDevelopmentPointType> DevelopmentPointType
		{
			get => GetProperty(ref _developmentPointType);
			set => SetProperty(ref _developmentPointType, value);
		}

		public AddDevelopmentPoints(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
