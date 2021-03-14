using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialAnimData : CVariable
	{
		private CName _hover_in;
		private CName _hover_out;
		private CName _cycle_in;
		private CName _cycle_out;

		[Ordinal(0)] 
		[RED("hover_in")] 
		public CName Hover_in
		{
			get
			{
				if (_hover_in == null)
				{
					_hover_in = (CName) CR2WTypeManager.Create("CName", "hover_in", cr2w, this);
				}
				return _hover_in;
			}
			set
			{
				if (_hover_in == value)
				{
					return;
				}
				_hover_in = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hover_out")] 
		public CName Hover_out
		{
			get
			{
				if (_hover_out == null)
				{
					_hover_out = (CName) CR2WTypeManager.Create("CName", "hover_out", cr2w, this);
				}
				return _hover_out;
			}
			set
			{
				if (_hover_out == value)
				{
					return;
				}
				_hover_out = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cycle_in")] 
		public CName Cycle_in
		{
			get
			{
				if (_cycle_in == null)
				{
					_cycle_in = (CName) CR2WTypeManager.Create("CName", "cycle_in", cr2w, this);
				}
				return _cycle_in;
			}
			set
			{
				if (_cycle_in == value)
				{
					return;
				}
				_cycle_in = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cycle_out")] 
		public CName Cycle_out
		{
			get
			{
				if (_cycle_out == null)
				{
					_cycle_out = (CName) CR2WTypeManager.Create("CName", "cycle_out", cr2w, this);
				}
				return _cycle_out;
			}
			set
			{
				if (_cycle_out == value)
				{
					return;
				}
				_cycle_out = value;
				PropertySet(this);
			}
		}

		public RadialAnimData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
