/*
 * Squidex Headless CMS
 *
 * @license
 * Copyright (c) Squidex UG (haftungsbeschränkt). All rights reserved.
 */

import { ChangeDetectionStrategy, Component, Input, OnChanges, SimpleChanges } from '@angular/core';

import { picasso } from '@app/framework/internal';

@Component({
    selector: 'sqx-avatar',
    styleUrls: ['./code.component.scss'],
    templateUrl: './code.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class AvatarComponent implements OnChanges {
    @Input()
    public identifier: string;

    @Input()
    public image: string;

    @Input()
    public size = 50;

    public imageSource: string | null;

    public sizeInPx: string;

    public ngOnChanges(changes: SimpleChanges) {
        if (changes['image']) {
            this.imageSource = this.image || this.createSvg();
        }

        if (changes['size']) {
            this.sizeInPx = `${this.size}px`;
        }
    }

    private createSvg() {
        if (this.identifier) {
            return `data:image/svg+xml;utf8,${picasso(this.identifier)}`;
        } else {
            return null;
        }
    }
}