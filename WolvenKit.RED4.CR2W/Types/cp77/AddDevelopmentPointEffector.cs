using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddDevelopmentPointEffector : gameEffector
	{
		private CInt32 _amount;
		private CEnum<gamedataDevelopmentPointType> _type;
		private TweakDBID _tdbid;

		[Ordinal(0)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CInt32) CR2WTypeManager.Create("Int32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataDevelopmentPointType>) CR2WTypeManager.Create("gamedataDevelopmentPointType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tdbid")] 
		public TweakDBID Tdbid
		{
			get
			{
				if (_tdbid == null)
				{
					_tdbid = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tdbid", cr2w, this);
				}
				return _tdbid;
			}
			set
			{
				if (_tdbid == value)
				{
					return;
				}
				_tdbid = value;
				PropertySet(this);
			}
		}

		public AddDevelopmentPointEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
