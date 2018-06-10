﻿''' <summary>
''' Field values present in an XC2 save file.
''' </summary>
Public Enum XC2DataType
    Money
    CommonItemID
    Common
    RareItemID
    Rare
    LegendaryItemID
    Legendary
    Magic
    Pyra_Trust
    Pyra_Cooldown_Timer
    Pyra_Art0_Level
    Pyra_Art1_Level
    Pyra_Art2_Level
    Pyra_Blade_Skills0_Level
    Pyra_Blade_Skills1_Level
    Pyra_Blade_Skills2_Level
    Pyra_Field_Skills0_Level
    Pyra_Field_Skills1_Level
    Pyra_Field_Skills2_Level
    Pyra_Weapon_Type
    Mythra_Trust
    Mythra_Cooldown_Timer
    Mythra_Art0_Level
    Mythra_Art1_Level
    Mythra_Art2_Level
    Mythra_Blade_Skills0_Level
    Mythra_Blade_Skills1_Level
    Mythra_Blade_Skills2_Level
    Mythra_Field_Skills0_Level
    Mythra_Field_Skills1_Level
    Mythra_Field_Skills2_Level
    Mythra_Weapon_Type
    Blade2_Trust
    Blade2_Cooldown_Timer
    Blade2_Weapon_Type
    Blade3_Trust
    Blade3_Weapon_Type
    Blade4_Trust
    Blade4_Weapon_Type
    Blade5_Trust
    Blade5_Weapon_Type
    Blade6_Trust
    Blade6_Weapon_Type
    Blade7_Trust
    Blade7_Weapon_Type
    Blade8_Trust
    Blade8_Weapon_Type
    Blade9_Trust
    Blade9_Weapon_Type
    Blade10_Trust
    Blade10_Weapon_Type
    Blade11_Trust
    Blade11_Weapon_Type
    Blade12_Trust
    Blade12_Weapon_Type
    Blade13_Trust
    Blade13_Weapon_Type
    Rex_BattleExp
    Rex_Bravery
    Rex_Truth
    Rex_Comp
    Rex_Justice
    Rex_HPMax
    Rex_Strength
    Rex_Ether
    Rex_Dex
    Rex_Agility
    Rex_Luck
    Rex_Exp
    Rex_Skill_Points
    Rex_Total_Skill_Points
    Rex_Battle_Exp
    Nia_Bravery
    Nia_Truth
    Nia_Comp
    Nia_Justice
    Nia_HPMax
    Nia_Stregth
    Nia_Ether
    Nia_Dexterity
    Nia_Agility
    Nia_Luck
    Nia_Exp
    Nia_Skill_Points
    Nia_Total_Skill_Points
    Nia_Battle_Exp
    Tora_Bravery
    Tora_Truth
    Tora_Comp
    Tora_Justice
    Tora_HPMax
    Tora_Stregth
    Tora_Ether
    Tora_Dexterity
    Tora_Agility
    Tora_Luck
    Tora_Exp
    Tora_Skill_Points
    Tora_Total_Skill_Points
    Tora_Battle_Exp
    Zeke_Bravery
    Zeke_Truth
    Zeke_Comp
    Zeke_Justice
    Zeke_HPMax
    Zeke_Stregth
    Zeke_Ether
    Zeke_Dexterity
    Zeke_Agility
    Zeke_Luck
    Zeke_Exp
    Zeke_Skill_Points
    Zeke_Total_Skill_Points
    Zeke_Battle_Exp
    Morag_Bravery
    Morag_Truth
    Morag_Comp
    Morag_Justice
    Morag_HPMax
    Morag_Stregth
    Morag_Ether
    Morag_Dexterity
    Morag_Agility
    Morag_Luck
    Morag_Exp
    Morag_Skill_Points
    Morag_Total_Skill_Points
    Morag_Battle_Exp
    Vandham_Bravery
    Vandham_Truth
    Vandham_Comp
    Vandham_Justice
    Vandham_HPMax
    Vandham_Stregth
    Vandham_Ether
    Vandham_Dexterity
    Vandham_Agility
    Vandham_Luck
    Vandham_Exp
    Vandham_Skill_Points
    Vandham_Total_Skill_Points
    Vandham_Battle_Exp
    Rex_Art_Weapon_0
    Rex_Art_Weapon_0_Total
    Rex_Art_Weapon_1
    Rex_Art_Weapon_1_Total
    Rex_Art_Weapon_2
    Rex_Art_Weapon_2_Total
    Rex_Art_Weapon_3
    Rex_Art_Weapon_3_Total
    Rex_Art_Weapon_4
    Rex_Art_Weapon_4_Total
    Rex_Art_Weapon_5
    Rex_Art_Weapon_5_Total
    Rex_Art_Weapon_6
    Rex_Art_Weapon_6_Total
    Rex_Art_Weapon_7
    Rex_Art_Weapon_7_Total
    Rex_Art_Weapon_8
    Rex_Art_Weapon_8_Total
    Rex_Art_Weapon_9
    Rex_Art_Weapon_9_Total
    Rex_Art_Weapon_10
    Rex_Art_Weapon_10_Total
    Rex_Art_Weapon_11
    Rex_Art_Weapon_11_Total
    Rex_Art_Weapon_12
    Rex_Art_Weapon_12_Total
    Rex_Art_Weapon_13
    Rex_Art_Weapon_13_Total
    Rex_Art_Weapon_14
    Rex_Art_Weapon_14_Total
    Rex_Art_Weapon_15
    Rex_Art_Weapon_15_Total
    Rex_Art_Weapon_16
    Rex_Art_Weapon_16_Total
    Rex_Art_Weapon_17
    Rex_Art_Weapon_17_Total
    Rex_Art_Weapon_18
    Rex_Art_Weapon_18_Total
    Rex_Art_Weapon_19
    Rex_Art_Weapon_19_Total
    Rex_Art_Weapon_20
    Rex_Art_Weapon_20_Total
    Rex_Art_Weapon_21
    Rex_Art_Weapon_21_Total
    Rex_Art_Weapon_22
    Rex_Art_Weapon_22_Total
    Rex_Art_Weapon_23
    Rex_Art_Weapon_23_Total
    Rex_Art_Weapon_24
    Rex_Art_Weapon_24_Total
    Rex_Art_Weapon_25
    Rex_Art_Weapon_25_Total
    Rex_Art_Weapon_26
    Rex_Art_Weapon_26_Total
    Nia_Art_Weapon_0
    Nia_Art_Weapon_0_Total
    Nia_Art_Weapon_1
    Nia_Art_Weapon_1_Total
    Nia_Art_Weapon_2
    Nia_Art_Weapon_2_Total
    Nia_Art_Weapon_3
    Nia_Art_Weapon_3_Total
    Nia_Art_Weapon_4
    Nia_Art_Weapon_4_Total
    Nia_Art_Weapon_5
    Nia_Art_Weapon_5_Total
    Nia_Art_Weapon_6
    Nia_Art_Weapon_6_Total
    Nia_Art_Weapon_7
    Nia_Art_Weapon_7_Total
    Nia_Art_Weapon_8
    Nia_Art_Weapon_8_Total
    Nia_Art_Weapon_9
    Nia_Art_Weapon_9_Total
    Nia_Art_Weapon_10
    Nia_Art_Weapon_10_Total
    Nia_Art_Weapon_11
    Nia_Art_Weapon_11_Total
    Nia_Art_Weapon_12
    Nia_Art_Weapon_12_Total
    Nia_Art_Weapon_13
    Nia_Art_Weapon_13_Total
    Nia_Art_Weapon_14
    Nia_Art_Weapon_14_Total
    Nia_Art_Weapon_15
    Nia_Art_Weapon_15_Total
    Nia_Art_Weapon_16
    Nia_Art_Weapon_16_Total
    Nia_Art_Weapon_17
    Nia_Art_Weapon_17_Total
    Nia_Art_Weapon_18
    Nia_Art_Weapon_18_Total
    Nia_Art_Weapon_19
    Nia_Art_Weapon_19_Total
    Nia_Art_Weapon_20
    Nia_Art_Weapon_20_Total
    Nia_Art_Weapon_21
    Nia_Art_Weapon_21_Total
    Nia_Art_Weapon_22
    Nia_Art_Weapon_22_Total
    Nia_Art_Weapon_23
    Nia_Art_Weapon_23_Total
    Nia_Art_Weapon_24
    Nia_Art_Weapon_24_Total
    Nia_Art_Weapon_25
    Nia_Art_Weapon_25_Total
    Nia_Art_Weapon_26
    Nia_Art_Weapon_26_Total
    Ether_Crystals
    MiniGame_0
    MiniGame_1
    MiniGame_2
    MiniGame_3
    MiniGame_4
    MiniGame_5
    MiniGame_6
    MiniGame_7
    MiniGame_8
    MiniGame_9
    MiniGame_10
    MiniGame_11
    MiniGame_12
    MiniGame_13
    MiniGame_14
    MiniGame_15
    MiniGame_16
    MiniGame_17
    MiniGame_18
    MiniGame_19
    MiniGame_20
    MiniGame_21
    MiniGame_22
    MiniGame_23
    MiniGame_24
    MiniGame_25
    MiniGame_26
    MiniGame_27
    MiniGame_28
    MiniGame_29
    MiniGame_30
    MiniGame_31
    MiniGame_32
    MiniGame_33
    MiniGame_34
    MiniGame_35
    MiniGame_36
    MiniGame_37
    MiniGame_38
    MiniGame_39
    MiniGame_40
    MiniGame_41
    MiniGame_42
    MiniGame_43
    MiniGame_44
    MiniGame_45
    MiniGame_46
    MiniGame_47
    MiniGame_48
    MiniGame_49
    MiniGame_50
    MiniGame_51
    MiniGame_52
    MiniGame_53
    MiniGame_54
    MiniGame_55
    MiniGame_56
    MiniGame_57
    MiniGame_58
    MiniGame_59
    MiniGame_60
    MiniGame_61
    MiniGame_62
    MiniGame_63
    MiniGame_64
    MiniGame_65
    MiniGame_66
    MiniGame_67
    MiniGame_68
    MiniGame_69
    MiniGame_70
    MiniGame_71
    MiniGame_72
    MiniGame_73
    MiniGame_74
    MiniGame_75
    MiniGame_76
    MiniGame_77
    MiniGame_78
    MiniGame_79
    MiniGame_80
    MiniGame_81
    MiniGame_82
    MiniGame_83
    MiniGame_84
    MiniGame_85
    MiniGame_86
    MiniGame_87
    MiniGame_88
    MiniGame_89
    MiniGame_90
    MiniGame_91
    MiniGame_92
    MiniGame_93
    MiniGame_94
    MiniGame_95
    MiniGame_96
    MiniGame_97
    MiniGame_98
    MiniGame_99
    MiniGame_100
    MiniGame_101
    MiniGame_102
    MiniGame_103
    MiniGame_104
    MiniGame_105
    MiniGame_106
    MiniGame_107
    MiniGame_108
    MiniGame_109
    MiniGame_110
    MiniGame_111
    MiniGame_112
    MiniGame_113
    MiniGame_114
    MiniGame_115
    MiniGame_116
    MiniGame_117
    MiniGame_118
    MiniGame_119
    MiniGame_120
    MiniGame_121
    MiniGame_122
    MiniGame_123
    MiniGame_124
    MiniGame_125
    MiniGame_126
    MiniGame_127
    MiniGame_128
    MiniGame_129
    MiniGame_130
    MiniGame_131
    MiniGame_132
    MiniGame_133
    MiniGame_134
    MiniGame_135
    MiniGame_136
    MiniGame_137
    MiniGame_138
    MiniGame_139
    MiniGame_140
    MiniGame_141
    MiniGame_142
    MiniGame_143
    MiniGame_144
    MiniGame_145
    MiniGame_146
    MiniGame_147
    MiniGame_148
    MiniGame_149
    MiniGame_150
    MiniGame_151
    MiniGame_152
    MiniGame_153
    MiniGame_154
    MiniGame_155
    MiniGame_156
    MiniGame_157
    MiniGame_158
    MiniGame_159
    MiniGame_160
    MiniGame_161
    MiniGame_162
    MiniGame_163
    MiniGame_164
    MiniGame_165
    MiniGame_166
    MiniGame_167
    MiniGame_168
    MiniGame_169
    MiniGame_170
    MiniGame_171
    MiniGame_172
    MiniGame_173
    MiniGame_174
    MiniGame_175
    MiniGame_176
    MiniGame_177
    MiniGame_178
    MiniGame_179
    MiniGame_180
    MiniGame_181
    MiniGame_182
    MiniGame_183
    MiniGame_184
    MiniGame_185
    MiniGame_186
    MiniGame_187
    MiniGame_188
    MiniGame_189
    MiniGame_190
    MiniGame_191
    MiniGame_192
    MiniGame_193
    MiniGame_194
    MiniGame_195
    MiniGame_196
    MiniGame_197
    MiniGame_198
    MiniGame_199
    MiniGame_200
    MiniGame_201
    MiniGame_202
    MiniGame_203
    MiniGame_204
    MiniGame_205
    MiniGame_206
    MiniGame_207
    MiniGame_208
    MiniGame_209
    MiniGame_210
    MiniGame_211
    MiniGame_212
    MiniGame_213
    MiniGame_214
    MiniGame_215
    MiniGame_216
    MiniGame_217
    MiniGame_218
    MiniGame_219
    MiniGame_220
    MiniGame_221
    MiniGame_222
    MiniGame_223
    MiniGame_224
    MiniGame_225
    MiniGame_226
    MiniGame_227
    MiniGame_228
    MiniGame_229
    MiniGame_230
    MiniGame_231
    MiniGame_232
    MiniGame_233
    MiniGame_234
    MiniGame_235
    MiniGame_236
    MiniGame_237
    MiniGame_238
    MiniGame_239
    MiniGame_240
    MiniGame_241
    MiniGame_242
    MiniGame_243
    MiniGame_244
    MiniGame_245
    MiniGame_246
    MiniGame_247
    MiniGame_248
    MiniGame_249
    MiniGame_250
    MiniGame_251
    MiniGame_252
    MiniGame_253
    MiniGame_254
    MiniGame_255
    Weapon_Chip_0
    Weapon_Chip_1
    Weapon_Chip_2
    Weapon_Chip_3
    Weapon_Chip_4
    Weapon_Chip_5
    Weapon_Chip_6
    Weapon_Chip_7
    Weapon_Chip_8
    Weapon_Chip_9
    Weapon_Chip_10
    Weapon_Chip_11
    Weapon_Chip_12
    Weapon_Chip_13
    Weapon_Chip_14
    Weapon_Chip_15
    Weapon_Chip_16
    Weapon_Chip_17
    Weapon_Chip_18
    Weapon_Chip_19
    Weapon_Chip_20
    Weapon_Chip_21
    Weapon_Chip_22
    Weapon_Chip_23
    Weapon_Chip_24
    Weapon_Chip_25
    Weapon_Chip_26
    Weapon_Chip_27
    Weapon_Chip_28
    Weapon_Chip_29
    TreasureBox_0
    TreasureBox_1
    TreasureBox_2
    TreasureBox_3
    TreasureBox_4
    TreasureBox_5
    TreasureBox_6
    TreasureBox_7
    TreasureBox_8
    TreasureBox_9
    TreasureBox_10
    TreasureBox_11
    TreasureBox_12
    TreasureBox_13
    TreasureBox_14
    TreasureBox_15
    TreasureBox_16
    TreasureBox_17
    TreasureBox_18
    TreasureBox_19
    TreasureBox_20
    TreasureBox_21
    TreasureBox_22
    TreasureBox_23
    TreasureBox_24
    TreasureBox_25
    TreasureBox_26
    Tora_Art_Weapon_0
    Tora_Art_Weapon_0_Total
    Tora_Art_Weapon_1
    Tora_Art_Weapon_1_Total
    Tora_Art_Weapon_2
    Tora_Art_Weapon_2_Total
    Tora_Art_Weapon_3
    Tora_Art_Weapon_3_Total
    Tora_Art_Weapon_4
    Tora_Art_Weapon_4_Total
    Tora_Art_Weapon_5
    Tora_Art_Weapon_5_Total
    Tora_Art_Weapon_6
    Tora_Art_Weapon_6_Total
    Tora_Art_Weapon_7
    Tora_Art_Weapon_7_Total
End Enum

