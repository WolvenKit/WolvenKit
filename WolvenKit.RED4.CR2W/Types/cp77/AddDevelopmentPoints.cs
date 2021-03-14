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
			get
			{
				if (_amountOfPoints == null)
				{
					_amountOfPoints = (CInt32) CR2WTypeManager.Create("Int32", "amountOfPoints", cr2w, this);
				}
				return _amountOfPoints;
			}
			set
			{
				if (_amountOfPoints == value)
				{
					return;
				}
				_amountOfPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("developmentPointType")] 
		public CEnum<gamedataDevelopmentPointType> DevelopmentPointType
		{
			get
			{
				if (_developmentPointType == null)
				{
					_developmentPointType = (CEnum<gamedataDevelopmentPointType>) CR2WTypeManager.Create("gamedataDevelopmentPointType", "developmentPointType", cr2w, this);
				}
				return _developmentPointType;
			}
			set
			{
				if (_developmentPointType == value)
				{
					return;
				}
				_developmentPointType = value;
				PropertySet(this);
			}
		}

		public AddDevelopmentPoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
