using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorColorRandom : IEvaluatorColor
	{
		private CColor _min;
		private CColor _max;
		private CBool _randomPerChannel;

		[Ordinal(0)] 
		[RED("min")] 
		public CColor Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CColor) CR2WTypeManager.Create("Color", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CColor Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CColor) CR2WTypeManager.Create("Color", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("randomPerChannel")] 
		public CBool RandomPerChannel
		{
			get
			{
				if (_randomPerChannel == null)
				{
					_randomPerChannel = (CBool) CR2WTypeManager.Create("Bool", "randomPerChannel", cr2w, this);
				}
				return _randomPerChannel;
			}
			set
			{
				if (_randomPerChannel == value)
				{
					return;
				}
				_randomPerChannel = value;
				PropertySet(this);
			}
		}

		public CEvaluatorColorRandom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
