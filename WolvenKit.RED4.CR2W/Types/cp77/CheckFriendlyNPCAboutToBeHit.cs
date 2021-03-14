using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckFriendlyNPCAboutToBeHit : StatusEffectTasks
	{
		private CHandle<AIArgumentMapping> _outStatusArgument;
		private CHandle<AIArgumentMapping> _outPositionStatusArgument;
		private CHandle<AIArgumentMapping> _outPositionArgument;

		[Ordinal(0)] 
		[RED("outStatusArgument")] 
		public CHandle<AIArgumentMapping> OutStatusArgument
		{
			get
			{
				if (_outStatusArgument == null)
				{
					_outStatusArgument = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outStatusArgument", cr2w, this);
				}
				return _outStatusArgument;
			}
			set
			{
				if (_outStatusArgument == value)
				{
					return;
				}
				_outStatusArgument = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outPositionStatusArgument")] 
		public CHandle<AIArgumentMapping> OutPositionStatusArgument
		{
			get
			{
				if (_outPositionStatusArgument == null)
				{
					_outPositionStatusArgument = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outPositionStatusArgument", cr2w, this);
				}
				return _outPositionStatusArgument;
			}
			set
			{
				if (_outPositionStatusArgument == value)
				{
					return;
				}
				_outPositionStatusArgument = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get
			{
				if (_outPositionArgument == null)
				{
					_outPositionArgument = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outPositionArgument", cr2w, this);
				}
				return _outPositionArgument;
			}
			set
			{
				if (_outPositionArgument == value)
				{
					return;
				}
				_outPositionArgument = value;
				PropertySet(this);
			}
		}

		public CheckFriendlyNPCAboutToBeHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
