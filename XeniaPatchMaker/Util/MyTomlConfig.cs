using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tommy;

namespace XeniaPatchMaker.Util
{
    internal class MyTomlConfig
    {
        #region PlaceHolders
        public static string DefaultSavePath;
        public static bool write_input_on_drop;
        public static bool use_default_authors;
        public static string Defaultauthors;
        public static bool Disable_Delete_Message;
        public static int AddressMath;
        public static bool Hide_Value_Converter;
        public static bool AutoDelete;
        public static bool isaddressuppercase;
        public static bool isvalueuppercase;
        public static System.Drawing.Color OutputTextColor;
        public static System.Drawing.Color default_ui_output_color;
        #endregion
        public static void WriteConfigFile(string Path = "Config.toml")
        {
            using (StreamReader reader = File.OpenText(Path))
            {
                // Parse the table
                TomlTable table = TOML.Parse(reader);

            }
        }
        public static void ReadConfigFile(string Path = "Config.toml")
        {
            using (StreamReader reader = File.OpenText(Path))
            {
                // Parse the table
                TomlTable table = TOML.Parse(reader);

            }
        }
        //
        public static void CreateConfigFile(string Path = "Config.toml")
        {
            // Generate a TOML
            TomlTable toml = new TomlTable
            {
                ["general_settings"] =
                         {
        ["default_save_path"] = new TomlString
    {
        Value = "",
        Comment = "allows user to set a default save path"
    }

                },
                ["main_header_settings"] =
                         {
                        ["write_input_on_drop"] = false.ToString()

                },
                ["patch_info_settings"] =
                         {
                        // You can also insert comments before a node with a special property

        ["use_default_Authors"] = new TomlString
    {
        Value = false.ToString(),
        Comment = "allows user to use a default author"
    },
        ["default_Authors"] = new TomlString
    {
        Value = "",
        Comment = "allows user to set a default author"
    },
        ["disable_delete_message"] = new TomlString
    {
        Value = false.ToString(),
        Comment = "allows user to disable Delete input warning message."
    },
            },
                ["patch_address_Header_Settings"] =
                         {
        ["address_math"] = new TomlString
    {
        Value = "1",
        Comment = "allows user to set custom math."
    },
        ["hide_value_converter"] = new TomlString
    {
        Value = false.ToString(),
        Comment = "allows user to Hide Value Converter."
    },
        ["auto_delete"] = new TomlString
    {
        Value = false.ToString(),
        Comment = "allows user to Auto Delete."
    },
    ["is_value_uppercase"] = false.ToString(),
    ["is_address_uppercase"] = false.ToString()
                },
                ["ui_settings"] =
                         {
    ["default_ui_text_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "allows the user to customize the text color."
    },
    ["default_ui_output_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "allows the user to customize the output window background color."
    },
    ["default_ui_style"] = new TomlString
    {
        Value = "visual studio 2013 dark",
        Comment = "allows the user to customize the ui style."
    },
    ["title_name_node_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "title name node for custom ui colors"
    },
    ["title_id_node_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "title id node for custom ui colors"
    },
    ["hash_node_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "hash node for custom ui colors"
    },
    ["patch_header_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "[[patch]] header for custom ui colors"
    },
    ["patch_name_node_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "patch name node for custom ui colors"
    },
    ["author_node_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "author node for custom ui colors"
    },
    ["is_enabled_node_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "patch switch node for custom ui colors"
    },
    ["patch_be_header_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "[[patch.be]] header for custom ui colors"
    },
    ["patch_address_node_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "hash node for custom ui colors"
    },
    ["patch_value_node_color"] = new TomlString
    {
        Value = "#FFFFFF",
        Comment = "patch value node for custom ui colors"
    }
                }
            };
            // Write to a file (or any TextWriter)
            // You can forcefully escape ALL Unicode characters by uncommenting the following line:
            // TOML.ForceASCII = true;
            using (StreamWriter writer = File.CreateText("Config.toml"))
            {
                toml.WriteTo(writer);
                // Remember to flush the data if needed!
                writer.Flush();
            }

        }
    }
}
