# CS_ARCH_ARM, CS_MODE_ARM, None
0x20,0x00,0xf0,0xf3 = vrev64.8 d16, d16
0x20,0x00,0xf4,0xf3 = vrev64.16 d16, d16
0x20,0x00,0xf8,0xf3 = vrev64.32 d16, d16
0x60,0x00,0xf0,0xf3 = vrev64.8 q8, q8
0x60,0x00,0xf4,0xf3 = vrev64.16 q8, q8
0x60,0x00,0xf8,0xf3 = vrev64.32 q8, q8
0xa0,0x00,0xf0,0xf3 = vrev32.8 d16, d16
0xa0,0x00,0xf4,0xf3 = vrev32.16 d16, d16
0xe0,0x00,0xf0,0xf3 = vrev32.8 q8, q8
0xe0,0x00,0xf4,0xf3 = vrev32.16 q8, q8
0x20,0x01,0xf0,0xf3 = vrev16.8 d16, d16
0x60,0x01,0xf0,0xf3 = vrev16.8 q8, q8
