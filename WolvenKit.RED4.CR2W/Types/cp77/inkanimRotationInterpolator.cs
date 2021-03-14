using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimRotationInterpolator : inkanimInterpolator
	{
		private CFloat _startValue;
		private CFloat _endValue;
		private CBool _goShortPath;

		[Ordinal(7)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get
			{
				if (_startValue == null)
				{
					_startValue = (CFloat) CR2WTypeManager.Create("Float", "startValue", cr2w, this);
				}
				return _startValue;
			}
			set
			{
				if (_startValue == value)
				{
					return;
				}
				_startValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get
			{
				if (_endValue == null)
				{
					_endValue = (CFloat) CR2WTypeManager.Create("Float", "endValue", cr2w, this);
				}
				return _endValue;
			}
			set
			{
				if (_endValue == value)
				{
					return;
				}
				_endValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("goShortPath")] 
		public CBool GoShortPath
		{
			get
			{
				if (_goShortPath == null)
				{
					_goShortPath = (CBool) CR2WTypeManager.Create("Bool", "goShortPath", cr2w, this);
				}
				return _goShortPath;
			}
			set
			{
				if (_goShortPath == value)
				{
					return;
				}
				_goShortPath = value;
				PropertySet(this);
			}
		}

		public inkanimRotationInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
