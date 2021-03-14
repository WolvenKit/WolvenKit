using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpTestComponent : gameComponent
	{
		private CFloat _whatever;
		private CFloat _whateverIE;

		[Ordinal(4)] 
		[RED("whatever")] 
		public CFloat Whatever
		{
			get
			{
				if (_whatever == null)
				{
					_whatever = (CFloat) CR2WTypeManager.Create("Float", "whatever", cr2w, this);
				}
				return _whatever;
			}
			set
			{
				if (_whatever == value)
				{
					return;
				}
				_whatever = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("whateverIE")] 
		public CFloat WhateverIE
		{
			get
			{
				if (_whateverIE == null)
				{
					_whateverIE = (CFloat) CR2WTypeManager.Create("Float", "whateverIE", cr2w, this);
				}
				return _whateverIE;
			}
			set
			{
				if (_whateverIE == value)
				{
					return;
				}
				_whateverIE = value;
				PropertySet(this);
			}
		}

		public cpTestComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
