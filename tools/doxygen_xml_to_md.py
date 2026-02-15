"""
generate_docs.py

Scans a directory for Doxygen-generated XML files whose names start with "class",
parses every method (memberdef kind="function") out of them, and writes a single
flat GitBook-style Markdown file listing each method with its signature and any
<para> documentation found in briefdescription / detaileddescription.

Usage:
    python generate_docs.py <input_directory> [output_file.md]

    input_directory  – folder containing the doxygen XML files
    output_file.md   – (optional) path to write; defaults to "docs.md" in CWD
"""

import sys
import os
import xml.etree.ElementTree as ET
from pathlib import Path

# ---------------------------------------------------------------------------
# Helpers
# ---------------------------------------------------------------------------

def collect_text(element: ET.Element | None) -> str:
    """Recursively collect all text content from an XML element, stripping
    surrounding whitespace.  Returns an empty string if the element is None."""
    if element is None:
        return ""
    # itertext() yields every text fragment in document-order (including tails)
    return " ".join(element.itertext()).strip()


def extract_docs(memberdef: ET.Element) -> dict:
    """Parse briefdescription and detaileddescription into three distinct buckets:

    Returns a dict:
        summary – str, the high-level description from <briefdescription>
        params  – list of (name: str, description: str) tuples, from <parameterlist>
        returns – str, the return description from <simplesect kind="return">
    """
    # --- Summary: plain text from briefdescription <para> elements ----------
    summary_parts: list[str] = []
    brief = memberdef.find("briefdescription")
    if brief is not None:
        for para in brief.iter("para"):
            text = collect_text(para).strip()
            if text:
                summary_parts.append(text)
    summary = " ".join(summary_parts)

    # --- Params & Returns: live inside detaileddescription -----------------
    params: list[tuple[str, str]] = []
    returns: str = ""

    detailed = memberdef.find("detaileddescription")
    if detailed is not None:
        # <parameterlist kind="param"> → one <parameteritem> per param
        for paramlist in detailed.iter("parameterlist"):
            if paramlist.get("kind") != "param":
                continue
            for item in paramlist.findall("parameteritem"):
                # Name is inside <parameternamelist><parametername>
                name_el = item.find(".//parametername")
                name = (name_el.text or "").strip() if name_el is not None else ""
                # Description is inside <parameterdescription>
                desc = collect_text(item.find("parameterdescription")).strip()
                if name:
                    params.append((name, desc))

        # <simplesect kind="return"> → single return description
        for simplesect in detailed.iter("simplesect"):
            if simplesect.get("kind") == "return":
                returns = collect_text(simplesect).strip()

    return {"summary": summary, "params": params, "returns": returns}


def build_signature(memberdef: ET.Element) -> str:
    """Build a clean, presentable signature using only the short method name.

    Format:
        MethodName(param1: Type1, param2: Type2 = default) → ReturnType
    """
    ret_type = collect_text(memberdef.find("type")).strip()
    method_name = (memberdef.findtext("name") or "").strip()

    # Parameters in "name: Type" style, which reads more naturally
    params: list[str] = []
    for param in memberdef.findall("param"):
        p_type = collect_text(param.find("type")).strip()
        p_name = (param.findtext("declname") or "").strip()
        p_default = (param.findtext("defval") or "").strip()

        if p_name:
            token = f"{p_name}: {p_type}"
        else:
            token = p_type

        if p_default:
            token += f" = {p_default}"
        params.append(token)

    params_str = ", ".join(params)
    signature = f"{method_name}({params_str})"

    # Append return type with an arrow, skip for constructors (no return type)
    if ret_type:
        signature += f" → {ret_type}"

    return signature


def is_constructor(memberdef: ET.Element) -> bool:
    """Doxygen marks constructors as functions with no <type> and where the
    method name matches the last segment of the qualified class name."""
    ret_type = collect_text(memberdef.find("type")).strip()
    if ret_type:
        return False  # constructors have no return type

    name = (memberdef.findtext("name") or "").strip()
    qualified = (memberdef.findtext("qualifiedname") or "").strip()

    # qualifiedname can be "Namespace::Class::Method" or "Namespace.Class.Method"
    # depending on language — normalise to a single separator before splitting
    parts = qualified.replace("::", ".").split(".")
    class_name = parts[-2] if len(parts) >= 2 else ""

    return name == class_name


# ---------------------------------------------------------------------------
# Core
# ---------------------------------------------------------------------------

def parse_class_xml(xml_path: Path) -> list[dict]:
    """Parse a single doxygen class XML file and return a list of method dicts,
    each with keys: signature (str), docs (dict with summary/params/returns).
    Constructors are skipped."""
    tree = ET.parse(xml_path)
    root = tree.getroot()

    methods: list[dict] = []
    for memberdef in root.iter("memberdef"):
        if memberdef.get("kind") != "function":
            continue
        if is_constructor(memberdef):
            continue

        signature = build_signature(memberdef)
        docs = extract_docs(memberdef)
        methods.append({"signature": signature, "docs": docs})

    return methods


def generate_markdown(all_methods: list[dict]) -> str:
    """Render each method with visually distinct sections for summary, params,
    and return value."""
    md_lines: list[str] = []

    for method in all_methods:
        docs = method["docs"]

        # Summary as a blockquote (only if present)
        if docs["summary"]:
            md_lines.append(f"> {docs['summary']}")

        # Parameters as a small table (only if any have descriptions)
        if docs["params"]:
            md_lines.append("")
            md_lines.append("| Parameter | Description |")
            md_lines.append("|-----------|-------------|")
            for name, desc in docs["params"]:
                # Escape any pipe characters in the description
                desc_safe = desc.replace("|", "\\|") if desc else "—"
                md_lines.append(f"| `{name}` | {desc_safe} |")

        # Return value as a bold label + inline text
        if docs["returns"]:
            md_lines.append("")
            md_lines.append(f"**Returns:** {docs['returns']}")

        # Signature
        md_lines.append("```csharp")
        md_lines.append(method["signature"])
        md_lines.append("```")

        md_lines.append("")  # blank line between entries
        md_lines.append("---")
        md_lines.append("")

    return "\n".join(md_lines)


def main() -> None:
    if len(sys.argv) < 2:
        print(__doc__)
        sys.exit(1)

    input_dir = Path(sys.argv[1]).resolve()
    output_path = Path(sys.argv[2]).resolve() if len(sys.argv) > 2 else Path("docs.md").resolve()

    if not input_dir.is_dir():
        print(f"Error: '{input_dir}' is not a directory.")
        sys.exit(1)

    # Collect all XML files whose *stem* starts with "class"
    xml_files = sorted(
        f for f in input_dir.iterdir()
        if f.suffix.lower() == ".xml" and f.stem.startswith("class")
    )

    if not xml_files:
        print(f"No XML files starting with 'class' found in '{input_dir}'.")
        sys.exit(0)

    all_methods: list[dict] = []
    for xml_file in xml_files:
        print(f"  Parsing {xml_file.name} …")
        all_methods.extend(parse_class_xml(xml_file))

    if not all_methods:
        print("No methods found in any of the parsed files.")
        sys.exit(0)

    markdown = generate_markdown(all_methods)
    output_path.write_text(markdown, encoding="utf-8")
    print(f"\nDone — {len(all_methods)} method(s) written to {output_path}")


if __name__ == "__main__":
    main()
